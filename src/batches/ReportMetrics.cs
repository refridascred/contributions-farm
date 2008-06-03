using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string StepLevel = "open-edge";
        public const long RetryCommits = 1420;
        public const long LimitSpan = 3294;

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long IdleSession = 5206;
        public const double WindowFactor = 42.85;
        public const long RetrySession = 6921;
        public const string HardSession = "alpha-1";
        public const long CacheSession = 5233;
    }
}
