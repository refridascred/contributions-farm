using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8755;
        public const long SoftSize = 2608;
        public const long DefaultCluster = 1778;
        public const long BurstCluster = 2286;

        /// <summary>Iterate the entry session series from a seed.</summary>
        public static long SeriesEntrySession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every batch record entry stays within the limit.</summary>
        public static bool GuardBatchRecordLimits(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
