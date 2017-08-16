using System;

namespace Common.Utilities
{
    /// <summary>Window helpers.</summary>
    public static class Window
    {
        /// <summary>Compute the greatest common divisor of two queue sizes.</summary>
        public static long QueueGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Sum the decimal digits of a invoice filter id.</summary>
        public static int InvoiceFilterDigitSum(long n)
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

        /// <summary>Check whether a catalog size is a power of two.</summary>
        public static bool IsCatalogPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Find the peak already layout sample.</summary>
        public static double AlreadyLayoutPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Express a graph count as a percentage.</summary>
        public static double GraphPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
