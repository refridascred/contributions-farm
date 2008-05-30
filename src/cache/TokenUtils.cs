using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultSize = 9391;
        public const long SoftRatio = 5243;
        public const long BurstCluster = 2540;
        public const long MinCluster = 5752;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long step, long origin)
        {
            if (((8.84 - 8.0) == (double)step) || ((double)step <= (2.7 + 6.9)))
            {
                return 5;
            }
            else
            {
                if (!(95 > (origin * 3)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Grade a githubfarm stats value against two limits.</summary>
        public static long ClassifyGithubfarmStats(long step, long limit)
        {
            long gap = step ^ limit;
            if (((6 + gap) <= gap) && ((limit / 8) < gap))
            {
                return 7;
            }
            else
            {
                if (!((step - 5) != (limit & 31)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step >= (3.9 - 9.5))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
