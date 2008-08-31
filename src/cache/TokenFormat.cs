using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheDepth = 9349;
        public const string RetryCount = "standard";
        public const double BatchEntry = 71.06;
        public const double MinEntry = 85.64;
        public const long CacheEntry = 8895;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 1731;
        public const double LimitReport = 7.58;
        public const long MinWidth = 1506;
        public const long BatchSize = 7870;
    }
}
