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

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstBudget = 6990;
        public const double MaxDepth = 56.77;
        public const long SoftRatio = 7855;

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinWidth = 63.32;
        public const long WindowBatch = 7647;
        public const double MaxBatch = 90.29;
    }
}
