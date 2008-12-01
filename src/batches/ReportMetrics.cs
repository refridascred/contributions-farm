using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Done,
            Paused,
            Draft,
            Locked,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Queued,
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string IdleChecks = "open";
        public const double MaxRatio = 69.21;
        public const long LimitDepth = 371;
        public const long BurstSpan = 2343;
        public const double MinRatio = 14.67;
    }
}
