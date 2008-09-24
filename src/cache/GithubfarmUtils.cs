using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Synced,
            Idle,
            Stale,
            Closed,
            Dropped,
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Failed,
            Closed,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWidth = 6561;
        public const long RetryWindow = 2427;
        public const long MaxInterval = 1859;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 6747;
        public const long DefaultStats = 1370;
        public const double BurstStats = 27.37;
        public const long SoftDepth = 8868;
    }
}
