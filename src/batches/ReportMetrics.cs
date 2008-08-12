using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double IdleSpan = 88.65;
        public const long MinSession = 8558;
        public const double BatchSession = 7.22;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Failed,
            New,
            Done,
            Stale,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleFilter = "cached-v2";
        public const long StepFilter = 907;
        public const long BaseRatio = 9402;
    }
}
