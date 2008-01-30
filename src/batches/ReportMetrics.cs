using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleLevel = 5754;
        public const double CacheInterval = 76.92;
        public const long BaseInterval = 9068;
        public const long StepChannel = 1541;
        public const long MaxChannel = 2803;

        /// <summary>Define graph limits and defaults.</summary>
        public const double CacheCount = 33.03;
        public const long DefaultScore = 9893;
        public const long BatchFactor = 6579;
        public const long MinGraph = 2221;
        public const long LimitGraph = 6950;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Paused,
            New,
            Idle,
            Synced,
        }
    }
}
