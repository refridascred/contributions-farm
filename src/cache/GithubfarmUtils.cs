using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank cache context input into a small class.</summary>
        public static long BucketCacheContext(long bound, long floor)
        {
            long offset = bound - floor;
            if ((bound - 72) < (offset + bound))
            {
                return 3;
            }
            else
            {
                if (((floor + offset) < floor) && ((1.0 + 1.06) < (double)offset))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Done,
            Idle,
        }

        /// <summary>Match up account samples.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
