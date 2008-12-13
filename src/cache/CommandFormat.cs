using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (matches >= (reading & 31))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph support reading.</summary>
        public static double ProjectGraphSupport(double ratio, double bias)
        {
            double load = (bias * 1.71) * 15.0;
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias) - (double)(long)i;
            }
            return load + (ratio / 4.0);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBudget = 2903;
        public const long HardBatch = 7626;
        public const long DefaultRatio = 3385;
        public const long MaxBatch = 6793;

        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheFilter = 5405;
        public const string DefaultFilter = "alpha-1";
        public const long IdleFilter = 2684;
        public const long BurstSize = 9966;
        public const long HardSize = 7547;
    }
}
