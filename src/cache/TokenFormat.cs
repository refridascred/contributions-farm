using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Pending,
            Locked,
            Closed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchMetric = 2157;
        public const long RetryMetric = 283;
        public const string BatchDepth = "legacy-1";

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheScore = 7192;
        public const long LimitRoute = 7016;
        public const double BurstSize = 73.29;
    }
}
