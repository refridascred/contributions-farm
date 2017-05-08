using System;

namespace Common.Utilities
{
    /// <summary>Filter metrics helpers.</summary>
    public static class FilterMetrics
    {
        /// <summary>Compute the greatest common divisor of two report sizes.</summary>
        public static long ReportGcd(long a, long b)
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

        /// <summary>Check whether a already size is a power of two.</summary>
        public static bool IsAlreadyPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
