using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "alpha";
        public const long RetryCommits = 1522;
        public const long CacheCommits = 5256;
        public const long DefaultCommits = 3238;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Done,
            Pending,
            Failed,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Token { get; set; }
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Active,
            Queued,
            Paused,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchFactor = 59.13;
        public const long MaxSize = 6220;
        public const double SoftFactor = 84.05;
        public const double StepBudget = 74.57;
    }
}
