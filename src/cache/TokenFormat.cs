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

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 79.07;
        public const long BatchWindow = 7799;
        public const long MaxLevel = 9156;
        public const double BaseWindow = 89.33;
        public const double CacheTimeout = 92.17;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 69.83;
        public const long DefaultCluster = 853;
        public const string StepLevel = "primary-edge";
        public const long HardCount = 3123;
    }
}
