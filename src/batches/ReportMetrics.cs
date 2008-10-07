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

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 5976;
        public const long BaseRatio = 5661;
        public const long StepLevel = 4885;
    }
}
