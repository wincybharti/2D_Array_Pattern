namespace _2D_Array_Pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Array = { { 1, 2, 3, 5 }, { 4, 5, 6, 10}, { 7, 8, 9,12 }, { 16,15,22,11} };

            int[] Pattern;

            //  0  1  2  3
            //0 1  2  3  5
            //1 4  5  6  10
            //2 7  8  9  12
            //3 16 15 22 11


            //for (int i = 0; i <= 4; i++)
            //{
            //    for (int j = 0; j <= i; j++)
            //    {
            //        Console.Write("* ");
            //    }
            //    for (int k = i; k < 4; k++)
            //    {
            //        Console.Write("- ");
            //    }
            //    Console.WriteLine(" ");
            //}

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(Array[i,0]);
            }
            for (int j = 1; j < 2; j++)
            {
                Console.WriteLine(Array[2, j]);
                Console.WriteLine(Array[j, 2]);
            }
            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine(Array[k,3]);
            }

            ////reverse N
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine(Array[i, 0]);
            //}
            //for (int i = 2; i >= 0; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.WriteLine(Array[i, j]);
            //    }
            //}

            //-----------------------------------
            ////U patter 
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine(Array[i, 0]);
            //}
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine(Array[3, i]);
            //}
            //for (int i = 2; i >= 0; i--)
            //{
            //    Console.WriteLine(Array[i, 3]);
            //}
            //--------------------------------------------
            ////opposite C pattern
            //for (int i = 0; i <= 3; i++)
            //{
            //    Console.WriteLine(Array[0, i]);
            //}
            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine(Array[i, 3]);
            //}
            //for (int i = 2; i >= 0; i--)
            //{
            //    Console.WriteLine(Array[3, i]);
            //}

        }
    }
}