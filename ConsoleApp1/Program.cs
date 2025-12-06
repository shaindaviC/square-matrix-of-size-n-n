using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter matrix size n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[n, n];

        Console.WriteLine("Enter the matrix values:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nMatrix:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(mat[i, j] + "\t");
            }
            Console.WriteLine();
        }

        int primarySum = 0;
        int secondarySum = 0;

        // Calculate both diagonals
        for (int i = 0; i < n; i++)
        {
            primarySum += mat[i, i];                 // mat[i][i]
            secondarySum += mat[i, n - 1 - i];       // mat[i][n-1-i]
        }

        // Output same as example
        Console.WriteLine("\nPrimary diagonal sum = " + primarySum);
        Console.WriteLine("Secondary diagonal sum = " + secondarySum);

        int diff = Math.Abs(primarySum - secondarySum);

        Console.WriteLine("Absolute difference = |" + primarySum + " - " + secondarySum + "| = " + diff);
    }
}
