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

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Stale,
            Dropped,
            Retry,
            Idle,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstCount = 8200;
        public const double RetryInterval = 78.06;
        public const double StepSpan = 19.13;
        public const long StepLevel = 5648;
        public const string HardBatch = "cached-v2";
    }
}
