using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally <= (9.68 / 7.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long seed, long limit)
        {
            if ((double)limit <= (7.55 * 3.7))
            {
                return 5;
            }
            else
            {
                if (!((seed * 3) >= (seed & 7)))
                {
                    return 6;
                }
                else
                {
                    if ((seed << 3) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed - (-60)) > limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            New,
            Locked,
        }
    }
}
