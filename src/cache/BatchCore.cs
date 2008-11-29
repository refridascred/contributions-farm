using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Region { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstRatio = 5468;
        public const double IdleMetric = 97.06;
        public const long RetryMetric = 9928;
        public const double IdleWidth = 26.72;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((2 + sample) != (207 - (-1)))
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
