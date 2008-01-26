using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a batch reading by value.</summary>
        public static long SeekBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxRatio = 3087;
        public const string CacheBudget = "cached-1";
        public const string MaxEntry = "latest-edge";
        public const long CacheEntry = 84;
        public const long LimitEntry = 3746;

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            New,
            Pending,
            Synced,
        }
    }
}
