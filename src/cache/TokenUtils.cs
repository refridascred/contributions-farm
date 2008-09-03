using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 82.87;
        public const long CacheSpan = 87;
        public const double DefaultScore = 85.94;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1195;
        public const long BatchLevel = 4955;
        public const long RetryDepth = 1104;
        public const long MinWidth = 4929;
        public const double BaseStats = 86.31;
    }
}
