using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheRatio = 8048;
        public const double HardBudget = 64.54;
        public const long HardWidth = 4556;
        public const long BaseSpan = 6185;

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheBudget = 2353;
        public const long StepCommits = 9341;
        public const string SoftInterval = "staging-edge";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Failed,
            Ready,
            Stale,
            Active,
        }
    }
}
