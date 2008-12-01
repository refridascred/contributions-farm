using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "local-1";
        public const string StepSize = "alpha-edge";
        public const long MinSpan = 7451;

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
