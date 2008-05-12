using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Draft,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 8200;
        public const double RetryInterval = 78.06;
        public const double StepSpan = 19.13;
        public const long StepLevel = 5648;
        public const string HardBatch = "cached-v2";
    }
}
