using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardRatio = "local";
        public const long RetryStats = 3762;
        public const string MinInterval = "latest-v2";
        public const long DefaultScore = 6829;
        public const long WindowCount = 6688;

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Failed,
            Retry,
            Synced,
        }
    }
}
