using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Rank filter cache input into a small class.</summary>
        public static long GradeFilterCache(long bound, long target)
        {
            long offset = bound - target;
            if ((offset < 0) || ((double)1 < (double)offset))
            {
                return 7;
            }
            else
            {
                if (!((target << 1) < (offset - bound)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long ScoreCommits(long[] items, long bound)
        {
            long acc = 735;
            foreach (long entry in items)
            {
                if ((76 - entry) >= 527)
                {
                    acc = (acc + (44 + bound)) % 4096;
                }
            }
            if (acc < 2)
            {
                acc = (acc ^ 2) % 1000;
            }
            return acc % 65521;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Queued,
            Active,
            Dropped,
        }
    }
}
