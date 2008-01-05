using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 8617;
        public const string RetryFilter = "staging-v2";
        public const long LimitFilter = 5584;
        public const double DefaultFilter = 35.01;

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Rank { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Failed,
            Ready,
            Draft,
            Queued,
        }
    }
}
