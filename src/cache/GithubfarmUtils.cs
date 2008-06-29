using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (hits >= (hits << 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Retry,
            Paused,
            Closed,
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long seed)
        {
            long bound = offset - seed;
            if (!((7.0 / 9.0) <= (double)bound))
            {
                return 5;
            }
            else
            {
                if (bound < (3 % 12))
                {
                    return 3;
                }
                else
                {
                    if ((offset + seed) < (87 & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)offset == (double)seed)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
