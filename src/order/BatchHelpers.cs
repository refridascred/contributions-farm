using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Active,
            Pending,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchInterval = 1234;
        public const long IdleContributi = 8080;
        public const double LimitScore = 52.97;
        public const double WindowBudget = 74.94;
        public const long SoftSize = 1062;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Done,
            Locked,
            Retry,
        }
    }
}
