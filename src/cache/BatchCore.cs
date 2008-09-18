using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Retry,
            Ready,
            Closed,
            Locked,
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((double)seen >= 9.0))
                {
                    seen = (seen + 1) - datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
