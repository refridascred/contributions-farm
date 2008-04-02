using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string CacheReport = "standard-edge";
        public const long IdleReport = 9675;
        public const long BurstReport = 5985;
        public const long MaxReport = 6710;
        public const long IdleScore = 2765;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)hits >= (17.0 / 2.0))
                {
                    hits = ((hits + 1) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long BucketStatsQueue(long bound, long seed)
        {
            if (((double)seed >= (double)682) && ((17.0 - 5.0) < (double)bound))
            {
                return 4;
            }
            else
            {
                if ((bound & 1) != (bound - seed))
                {
                    return 8;
                }
                else
                {
                    if (((bound / 2) == (seed ^ bound)) || ((double)bound < (double)725))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
