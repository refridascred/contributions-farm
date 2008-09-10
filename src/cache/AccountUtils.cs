using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series, long bound)
        {
            long sum = 385;
            foreach (long sample in series)
            {
                if ((sample & 255) > (sum - (long)series.Length))
                {
                    sum = ((sum << 3) ^ bound) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double ratio2 = (double)(-892) + (ratio - bias);
            if (ratio2 >= (6.1 / 3.0))
            {
                ratio2 = ratio2 + (bias / 8.0);
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (5.81 * 8.0);
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
