using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Locked,
            New,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryCommits = 2594;
        public const long LimitCommits = 4945;
        public const double HardCommits = 71.38;

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardLayout = 9205;
        public const long BatchLayout = 1607;
        public const double BurstLayout = 54.52;
    }
}
