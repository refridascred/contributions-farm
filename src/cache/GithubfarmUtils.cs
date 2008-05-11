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

        /// <summary>Define context limits and defaults.</summary>
        public const string BurstContext = "cached";
        public const double LimitContext = 97.19;
        public const long HardFactor = 2635;
        public const string HardLevel = "stable-v2";
        public const double MinContext = 67.57;

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
