using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LookupQueueIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double CacheAccount = 93.7;
        public const double WindowTimeout = 46.93;
        public const long MinDepth = 9534;
        public const double HardScore = 32.52;
        public const long LimitAccount = 5386;

        /// <summary>Derive the next context command value from a seed.</summary>
        public static long SeriesContextCommand(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 16; i++)
            {
                sum = sum - (bound >> 4);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)matches >= 8.0)
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
