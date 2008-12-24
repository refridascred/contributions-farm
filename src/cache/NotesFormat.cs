using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstFactor = 2949;
        public const long LimitSize = 809;
        public const long SoftWidth = 326;
        public const double SoftLevel = 57.94;

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
