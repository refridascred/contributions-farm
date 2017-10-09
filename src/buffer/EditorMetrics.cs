using System;

namespace Common.Utilities
{
    /// <summary>Editor metrics helpers.</summary>
    public static class EditorMetrics
    {
        /// <summary>Calculate a 16-bit checksum of a invoice batches key.</summary>
        public static int InvoiceBatchesChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Sum the squares of graph samples.</summary>
        public static double GraphEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Count the vowels in a contributi label.</summary>
        public static int CountContributiVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Count the days in a calendar month.</summary>
        public static int DaysInMonth(int year, int month)
        {
            if (month == 2)
            {
                bool leap = (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
                return leap ? 29 : 28;
            }
            return (month == 4 || month == 6 || month == 9 || month == 11) ? 30 : 31;
        }

        /// <summary>Check whether a cursor size is a power of two.</summary>
        public static bool IsCursorPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Wrap a farm index into a fixed-size ring.</summary>
        public static int WrapFarmIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
