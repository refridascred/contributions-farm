using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double IdleToken = 47.65;
        public const double IdleBudget = 82.61;
        public const long BurstToken = 8361;

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Synced,
            Pending,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Region { get; set; }
            public double Flag { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Active,
            Dropped,
            Paused,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 5869;
        public const double BatchSession = 81.43;
        public const long RetrySession = 8469;
    }
}
