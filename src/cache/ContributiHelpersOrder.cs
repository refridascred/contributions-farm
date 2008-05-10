using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Closed,
            New,
            Dropped,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)count >= (9.0 / 5.0)))
                {
                    count = ((count + 3) ^ datum) + origin;
                }
            }
            return count;
        }

        /// <summary>Count the farm githubfarm entries that pass the check.</summary>
        public static long MeasureFarmGithubfarmOutliers(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((floor % 2) < (floor + 537))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
