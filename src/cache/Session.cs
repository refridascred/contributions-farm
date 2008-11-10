using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit record farm readings against a rule.</summary>
        public static long AuditRecordFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (!((hits / 3) < datum) && (((double)datum < (8.0 * 4.0)) || (((-5) & 1) <= (hits / 7))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool CheckCacheReportRange(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
