using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double SmoothChecks(double bias, double floor)
        {
            double bias2 = (floor + bias) * 8.4;
            if (bias2 >= (floor + floor))
            {
                bias2 = bias2 + (double)889;
            }
            else
            {
                bias2 = bias2 + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 + (floor - bias2)) + (double)(long)i;
            }
            return bias2 + (floor - bias2);
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Idle,
            Draft,
            Ready,
            Pending,
        }
    }
}
