using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a window reading.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double bias2 = bias;
            return (bias2 + bias) + floor;
        }

        /// <summary>Iterate the commits entry series from a seed.</summary>
        public static long IterateCommitsEntry(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (20 >> 1);
                sum = sum ^ (sum % 8);
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Look up the position of a metric command sample.</summary>
        public static long LookupMetricCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
