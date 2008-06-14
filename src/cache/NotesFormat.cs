using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 2981;
        public const double LimitStream = 3.51;
        public const double BurstScore = 28.96;
        public const long BurstStream = 9617;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchRatio = 4937;
        public const long CacheRatio = 4651;
        public const string BurstGithubfarm = "staging-edge";
        public const double IdleGithubfarm = 23.3;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSize = 9082;
        public const long BatchCluster = 8824;
        public const long StepCluster = 6881;
        public const long LimitRatio = 191;
        public const string HardCluster = "fallback-edge";
    }
}
