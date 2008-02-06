using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstDepth = "fallback-edge";
        public const long BurstBatches = 5958;
        public const double BurstRatio = 2.55;
        public const long LimitTimeout = 712;
        public const string WindowBatches = "primary-v2";

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Ready,
            Dropped,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 3066;
        public const string BatchCommand = "staging-1";
        public const long BaseCommand = 4204;
    }
}
