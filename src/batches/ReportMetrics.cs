using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5486;
        public const long CacheTimeout = 5584;
        public const string SoftBatch = "primary-v2";
        public const long HardBatch = 312;
        public const long RetryTimeout = 5998;
    }
}
