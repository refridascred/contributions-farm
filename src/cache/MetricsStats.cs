using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor >> 5) <= (lane + floor))
            {
                return 8;
            }
            else
            {
                if ((lane % 7) >= 42)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long MeasureContributiCacheGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally >= (3.05 * 3.0))
                {
                    tally = ((tally + 3) - item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultFarm = 8691;
        public const long WindowFarm = 2457;
        public const double BurstCount = 22.2;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
