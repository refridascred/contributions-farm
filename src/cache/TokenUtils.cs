using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Done,
            Stale,
            Ready,
            Failed,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 30.01;
        public const double DefaultCount = 36.2;
        public const long DefaultMetric = 1365;

        /// <summary>Define command limits and defaults.</summary>
        public const double RetryDepth = 57.88;
        public const string WindowSize = "alpha-1";
        public const long MinCommand = 2473;
    }
}
