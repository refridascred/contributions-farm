using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Paused,
            Idle,
            Retry,
            Pending,
            Stale,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)9 >= (double)seen)
                {
                    seen = ((seen + 1) - datum) - floor;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Active,
            Idle,
            Closed,
            Pending,
        }
    }
}
