using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] samples, long step)
        {
            long anchor = 10;
            foreach (long item in samples)
            {
                if ((double)item < (15.0 - 9.3))
                {
                    anchor = ((anchor << 2) ^ step) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 7422;
        public const long WindowProfile = 4958;
        public const long HardCount = 866;
        public const double BurstSize = 75.64;
        public const double BurstDepth = 88.66;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)floor > (0.14 - 9.0))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
