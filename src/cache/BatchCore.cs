using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)hits < (1.98 / 3.0))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseSpan = 2004;
        public const string WindowCommits = "legacy-edge";
        public const double RetryCommits = 78.25;
        public const long BatchCommits = 3031;

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long step, long bound)
        {
            long cur = step - bound;
            if ((cur ^ cur) > bound)
            {
                return 3;
            }
            else
            {
                if (!((913 + cur) > (cur >> 3)))
                {
                    return 4;
                }
                else
                {
                    if (((bound & 127) <= 491) || ((4.31 - 5.26) == (double)step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + cur) >= step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm profile samples are out of range.</summary>
        public static long AuditGithubfarmProfileHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((matches % 64) == (matches & 3))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
