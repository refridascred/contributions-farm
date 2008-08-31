using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long HardEntry = 5840;
        public const double HardTimeout = 26.94;
        public const long MinEntry = 50;
        public const long WindowRatio = 5653;
        public const long CacheRatio = 1270;

        /// <summary>Define stats limits and defaults.</summary>
        public const string CacheFactor = "legacy-1";
        public const long CacheStats = 1364;
        public const string BatchStats = "local";
        public const string BaseTimeout = "primary-1";

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public long Offset { get; set; }
        }
    }
}
