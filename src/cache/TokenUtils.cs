using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxCount = 40.84;
        public const long WindowFarm = 7273;
        public const long BatchFarm = 6951;
        public const long BaseBudget = 8650;
        public const string MaxFarm = "stable";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double floor)
        {
            double mean = 6.8;
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (mean * 0.4)) + (double)(long)i;
            }
            return mean - (floor + bias);
        }
    }
}
