using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            New,
            Done,
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            New,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstChecks = 7525;
        public const long MinFactor = 744;
        public const string BurstFactor = "fallback-v2";
    }
}
