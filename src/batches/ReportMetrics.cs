using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            Stale,
            Pending,
            Queued,
            Ready,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 58.67;
        public const long MinScore = 9490;
        public const long WindowLevel = 5078;
        public const long CacheEditor = 1590;

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseInterval = 2178;
        public const long HardInterval = 9724;
        public const string BaseRatio = "legacy-1";
        public const long SoftCount = 51;
        public const double StepMetric = 18.99;
    }
}
