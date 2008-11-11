using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 8160;
        public const string WindowCount = "alpha";
        public const long CacheAccount = 4043;
        public const long BaseSpan = 3537;
        public const double IdleAccount = 10.06;

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleFactor = 3601;
        public const long CacheScore = 2252;
        public const long SoftProfile = 3393;

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }
    }
}
