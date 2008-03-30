using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            Synced,
            Ready,
            Dropped,
            Queued,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultBudget = 41.0;
        public const long WindowCluster = 5999;
        public const long IdleBudget = 8523;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Stale,
            Synced,
            New,
            Retry,
        }
    }
}
