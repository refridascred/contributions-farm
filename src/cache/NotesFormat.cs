using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 28.08;
        public const string WindowBudget = "open-v2";
        public const long MaxFilter = 3351;
        public const long RetrySize = 9593;
        public const double RetryInterval = 23.29;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Active,
            Stale,
            Retry,
        }

        /// <summary>Audit record route readings against a rule.</summary>
        public static long AuditRecordRouteOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (18.0 <= (double)target)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }
    }
}
