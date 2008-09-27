using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
