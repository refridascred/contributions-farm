using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Total { get; set; }
            public double Token { get; set; }
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 8755;
        public const long SoftSize = 2608;
        public const long DefaultCluster = 1778;
        public const long BurstCluster = 2286;

        /// <summary>Roll a stream queue counter forward.</summary>
        public static long SeriesStreamQueue(long seed)
        {
            long total = seed;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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
