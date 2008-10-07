using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Active,
            Dropped,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 4299;
        public const string SoftChecks = "fallback-1";
        public const string MaxRatio = "alpha-v2";
        public const long CacheSize = 2925;
        public const string WindowChecks = "stable-edge";
    }
}
