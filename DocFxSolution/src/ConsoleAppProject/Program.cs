namespace ConsoleAppProject;

/// <summary>
/// アプリケーションのエントリーポイントを提供するクラス
/// </summary>
public class Program
{
    /// <summary>
    /// アプリケーションのメインメソッド
    /// </summary>
    /// <param name="args">コマンドライン引数の配列</param>
    public static void Main(string[] args)
    {
        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        if (args.Length > 0)
        {
            Console.WriteLine("コマンドライン引数:");
            foreach (var arg in args)
            {
                Console.WriteLine($"- {arg}");
            }
        }
        else
        {
            Console.WriteLine("引数は指定されていません。");
        }
    }
}
