using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first githubfarm commits entry that matches the target.</summary>
        public static long LocateGithubfarmCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((1 / 5) > item)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((377 ^ hits) == (hits + sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteHits(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell % 2) < (tally + (-583)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of session profile entries.</summary>
        public static long DigestSessionProfile(long[] levels, long bound)
        {
            long anchor = 46;
            foreach (long entry in levels)
            {
                if ((double)anchor <= (12.0 * 4.3))
                {
                    anchor = ((anchor + (bound - bound)) % 97) - entry;
                }
                if ((double)675 > (double)bound)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
