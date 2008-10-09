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

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseDepth = "open-v2";
        public const long RetryTimeout = 3940;
        public const double DefaultBatch = 47.6;
    }
}
