using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Retry,
            Active,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchTimeout = 30.16;
        public const long RetryFormat = 5025;
        public const long RetryLevel = 6387;
        public const string BatchCount = "primary-1";

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
