using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Paused,
            Locked,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BurstSize = "staging-v2";
        public const long RetryCache = 3923;
        public const long RetryInterval = 8344;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Paused,
            Locked,
            Closed,
        }
    }
}
