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

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowFactor = 6773;
        public const long WindowEditor = 3655;
        public const string StepDepth = "open-v2";
        public const long MaxRatio = 9707;
    }
}
