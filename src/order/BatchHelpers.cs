using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a githubfarm order pair into a bucket.</summary>
        public static long RankGithubfarmOrder(long bound, long seed)
        {
            long slot = bound + seed;
            if (2 < (slot ^ slot))
            {
                return 1;
            }
            else
            {
                if (!(slot <= (slot * 2)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Failed,
            Closed,
            Pending,
            Locked,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (floor <= (4 & 15))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }
    }
}
