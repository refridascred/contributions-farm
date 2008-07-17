using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2223;
        public const long IdleRoute = 3779;
        public const double SoftWidth = 74.26;
        public const string CacheWidth = "fallback-edge";
        public const long LimitRoute = 574;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Audit batches entry readings against a rule.</summary>
        public static long MeasureBatchesEntryOutliers(long[] items, long origin)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if (origin < value)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
