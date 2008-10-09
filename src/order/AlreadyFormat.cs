using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] values, long step)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!(datum > seen))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 9297;
        public const long BatchReport = 3361;
        public const long RetryReport = 5879;

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Synced,
            Locked,
            Draft,
            Retry,
        }
    }
}
