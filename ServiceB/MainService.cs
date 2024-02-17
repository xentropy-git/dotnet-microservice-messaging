namespace ServiceB;

public class MainService : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
       while (!stoppingToken.IsCancellationRequested)
       {
           Console.WriteLine("ServiceB is running.");
           await Task.Delay(1000, stoppingToken);
       } 
    }
}