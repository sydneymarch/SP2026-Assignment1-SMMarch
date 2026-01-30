namespace SP2026_Assignment1_SMMarch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.UseDefaultFiles(); //spins up index.htm index.html default.htm default.html
            app.UseStaticFiles(); //serving regular html files

            app.Run();
        }
    }
}
