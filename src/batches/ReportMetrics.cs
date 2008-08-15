using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 3177;
        public const long IdleEditor = 4588;
        public const long MaxEditor = 5347;
        public const string LimitFactor = "staging-1";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string StepGithubfarm = "cached-1";
        public const long BatchScore = 1849;
        public const string MinGithubfarm = "stable-v2";
        public const long HardSpan = 6790;
        public const long WindowGithubfarm = 6045;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Active,
            Failed,
        }
    }
}
