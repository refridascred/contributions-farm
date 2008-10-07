using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((6 / 6) < (item >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinFactor = 3279;
        public const long CacheBatch = 4048;
        public const long MinBatch = 4831;
        public const string LimitFactor = "cached-v2";

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            New,
            Draft,
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Digest a series of command counter entries.</summary>
        public static long WeighCommandCounter(long[] samples, long bound)
        {
            long result = 98;
            foreach (long entry in samples)
            {
                result = (result ^ (entry ^ bound)) % 101;
            }
            return result;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long target, long limit)
        {
            if ((double)limit <= (8.8 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((double)6 <= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
