using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Ready,
            New,
            Done,
            Paused,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Draft,
            Pending,
            Closed,
            Dropped,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 239;
        public const long LimitRatio = 8282;
        public const double MaxDepth = 48.33;
    }
}
