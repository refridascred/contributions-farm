using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 6751;
        public const double CacheDepth = 18.07;
        public const long BurstMetric = 4498;
        public const long MinMetric = 3258;
        public const string MaxMetric = "stable-v2";

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long limit, long bound)
        {
            if ((limit + limit) != (limit - bound))
            {
                return 3;
            }
            else
            {
                if ((bound + limit) >= (limit - limit))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the stats counter entries that pass the check.</summary>
        public static long MeasureStatsCounterMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((8.0 * 15.0) >= (double)sample)
                {
                    count = (count + 3) - origin;
                }
            }
            return count;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long limit)
        {
            if (79 <= limit)
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (1.5 * 8.66))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
