using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 69.83;
        public const long DefaultCluster = 853;
        public const string StepLevel = "primary-edge";
        public const long HardCount = 3123;
    }
}
