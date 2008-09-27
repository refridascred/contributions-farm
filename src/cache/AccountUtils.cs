using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long limit)
        {
            long edge = floor - limit;
            if ((floor < (floor - limit)) && ((11.0 - 6.5) > (double)edge))
            {
                return 3;
            }
            else
            {
                if (((9.0 - 3.9) != (double)edge) && ((double)limit > (9.78 - 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((floor - limit) > edge)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
