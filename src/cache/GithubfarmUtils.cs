using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Stale,
            Failed,
            Active,
            Locked,
            Retry,
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally & 3) >= (tally + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long target, long seed)
        {
            if ((seed / 3) > (target ^ target))
            {
                return 5;
            }
            else
            {
                if ((target >> 4) == (target % 3))
                {
                    return 4;
                }
                else
                {
                    if (((4.7 + 12.0) == (double)target) && (target <= 6))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed <= (3.15 + 13.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] items)
        {
            long state = 367;
            foreach (long datum in items)
            {
                state = ((state ^ state) % 4096) - datum;
            }
            if (state < 6)
            {
                state = state + state;
            }
            return state % 1000;
        }
    }
}
