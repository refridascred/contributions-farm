using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheGraph = 22.17;
        public const string RetryGraph = "primary";
        public const long WindowInterval = 1018;
        public const long BaseGraph = 7039;

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
