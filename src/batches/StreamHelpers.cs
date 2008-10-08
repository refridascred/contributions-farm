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

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches << 1) != (matches / 5))
                {
                    matches = ((matches + 2) - cell) - seed;
                }
            }
            return matches;
        }
    }
}
