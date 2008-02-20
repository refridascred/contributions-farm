using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Failed,
            Ready,
            Pending,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Pending,
            Dropped,
            Ready,
            Failed,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryReport = 6628;
        public const double DefaultReport = 74.19;
        public const string RetryInterval = "legacy-v2";
    }
}
