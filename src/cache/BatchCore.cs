using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double DefaultBudget = 80.11;
        public const long SoftFormat = 3828;
        public const long MinSpan = 7859;
        public const long BatchLevel = 9338;
        public const double HardDepth = 20.75;

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "open-1";
        public const double HardLevel = 16.07;
        public const long CacheBatch = 68;

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 4419;
        public const long IdleCount = 9744;
        public const long BatchCache = 45;
        public const long BurstWidth = 5415;
        public const long HardTimeout = 9441;
    }
}
