using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Done,
            Paused,
            Failed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Done,
            Ready,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFilter = 6134;
        public const long BaseDepth = 9856;
        public const string BurstSpan = "open-edge";
        public const double BurstScore = 11.33;
        public const long BurstFilter = 7316;

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinWidth = 63.32;
        public const long WindowBatch = 7647;
        public const double MaxBatch = 90.29;
    }
}
