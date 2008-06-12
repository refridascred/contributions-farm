using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Stale,
            New,
            Paused,
            Synced,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "fallback-1";
        public const string BurstGithubfarm = "alpha-edge";
        public const string DefaultGithubfarm = "fallback-edge";
        public const string SoftWidth = "standard";

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Failed,
            Idle,
            Stale,
            Draft,
            Closed,
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Closed,
            Ready,
            Paused,
            New,
            Pending,
        }
    }
}
