using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] series, long origin)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((19 - origin) > hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Paused,
            Failed,
            Closed,
            Pending,
            New,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportRange(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((item >> 1) < 8) && (((hits + item) <= item) || (1.9 <= (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Paused,
            Active,
            Failed,
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            New,
            Done,
            Active,
            Closed,
        }
    }
}
