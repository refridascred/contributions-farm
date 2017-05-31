using System;

namespace Common.Utilities
{
    /// <summary>Buffer format helpers.</summary>
    public static class BufferFormat
    {
        /// <summary>Sum the decimal digits of a context commits id.</summary>
        public static int ContextCommitsDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Sum the squares of cluster samples.</summary>
        public static double ClusterEnergy(double[] values)
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

        /// <summary>Count the vowels in a layout buffer label.</summary>
        public static int CountLayoutBufferVowels(string text)
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

        /// <summary>Sum the squares of entry ticket samples.</summary>
        public static double EntryTicketEnergy(double[] values)
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

        /// <summary>Convert a farm temperature from celsius to fahrenheit.</summary>
        public static double FarmCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Clamp a counter value to a valid range.</summary>
        public static double ClampCounter(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }
    }
}
