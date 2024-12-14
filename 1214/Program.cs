namespace _1214
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 宣告陣列
            int[] ints = new int[10];
            float[] floats = new float[8];
            double[] doubles = new double[4];
            string[] strings = new string[5];

            // 處理整數陣列
            Console.WriteLine("請輸入 10 個整數：");
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write($"第 {i + 1} 個整數: ");
                ints[i] = int.Parse(Console.ReadLine()); // 接收使用者輸入並轉為整數
            }
            Console.WriteLine("\n整數陣列內容：");
            foreach (int num in ints)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\n整數陣列的平均值: {GetAverage(ints)}");

            // 處理浮點數陣列
            Console.WriteLine("\n請輸入 8 個浮點數：");
            for (int i = 0; i < floats.Length; i++)
            {
                Console.Write($"第 {i + 1} 個浮點數: ");
                floats[i] = float.Parse(Console.ReadLine()); // 接收使用者輸入並轉為浮點數
            }
            Console.WriteLine("\n浮點數陣列內容：");
            foreach (float num in floats)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\n浮點數陣列的平均值: {GetAverage(floats)}");

            // 處理雙精度浮點數陣列
            Console.WriteLine("\n請輸入 4 個雙精度浮點數：");
            for (int i = 0; i < doubles.Length; i++)
            {
                Console.Write($"第 {i + 1} 個雙精度浮點數: ");
                doubles[i] = double.Parse(Console.ReadLine()); // 接收使用者輸入並轉為雙精度浮點數
            }
            Console.WriteLine("\n雙精度浮點數陣列內容：");
            foreach (double num in doubles)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine($"\n雙精度浮點數陣列的平均值: {GetAverage(doubles)}");

            // 處理字串陣列
            Console.WriteLine("\n請輸入 5 個字串：");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write($"第 {i + 1} 個字串: ");
                strings[i] = Console.ReadLine(); // 接收使用者輸入的字串
            }
            Console.WriteLine("\n字串陣列內容：");
            foreach (string str in strings)
            {
                Console.WriteLine(str);
            }
        }

        // 計算整數平均值
        static double GetAverage(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
            {
                sum += num;
            }
            return (double)sum / arr.Length;
        }

        // 計算浮點數平均值
        static double GetAverage(float[] arr)
        {
            float sum = 0;
            foreach (float num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }

        // 計算雙精度浮點數平均值
        static double GetAverage(double[] arr)
        {
            double sum = 0;
            foreach (double num in arr)
            {
                sum += num;
            }
            return sum / arr.Length;
        }
    }
}

