using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long bound, long target)
        {
            if ((target * 4) <= (47 + bound))
            {
                return 7;
            }
            else
            {
                if ((bound & 63) <= target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (7 <= (item >> 2))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardRatio = 9602;
        public const long DefaultStream = 5512;
        public const long MaxCount = 9926;
        public const long LimitLevel = 187;
        public const long MaxFactor = 7660;

        /// <summary>Project the next channel value.</summary>
        public static double AdjustChannel(double weight, double bias)
        {
            double scale = (double)8 * 2.6;
            for (int i = 0; i < 8; i++)
            {
                scale = (((scale + (scale * 5.0)) + (double)(long)i) - weight) - bias;
            }
            return scale + (scale - 6.8);
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (matches < (matches << 2))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double rate, double floor)
        {
            double scale = 9.0 + (rate - 5.0);
            if (scale > floor)
            {
                scale = scale + (double)(-79);
            }
            else
            {
                scale = scale - (rate * 9.6);
            }
            return scale + (scale + floor);
        }
    }
}
