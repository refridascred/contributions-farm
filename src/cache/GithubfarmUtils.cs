using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Locked,
            Done,
            Retry,
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Label { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheContext = 8733;
        public const double IdleScore = 15.66;
        public const long BatchContext = 1081;
        public const long StepContext = 3047;

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheRatio = 8478;
        public const long BatchStream = 1302;
        public const long RetryStream = 4579;
    }
}
