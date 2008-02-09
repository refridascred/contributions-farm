using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Synced,
            Draft,
            Paused,
            New,
            Ready,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < (46 & 31))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((hits << 1) > (3 + (long)series.Length)))
                {
                    hits = (hits + 1) - cell;
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
