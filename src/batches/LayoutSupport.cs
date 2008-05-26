using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Locked,
            Done,
            Queued,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchBudget = 78.28;
        public const long CacheLevel = 4173;
        public const double BaseFactor = 51.52;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Retry,
            New,
            Failed,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepDepth = 8.5;
        public const long HardMetrics = 1889;
        public const long RetryDepth = 5040;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Done,
            Retry,
            Synced,
        }
    }
}
