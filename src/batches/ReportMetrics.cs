using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            New,
            Failed,
            Synced,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double SoftRatio = 8.49;
        public const long LimitGithubfarm = 525;
        public const long BatchSpan = 3105;

        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 26.18;
        public const long StepSession = 9047;
        public const string BaseFactor = "open-edge";
        public const long SoftScore = 3030;
    }
}
