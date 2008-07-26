using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Paused,
            Done,
            Synced,
            Idle,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long step, long step2)
        {
            if ((5 - step2) >= (step2 << 1))
            {
                return 2;
            }
            else
            {
                if (((87 & 3) == (step2 - step2)) || ((double)step2 == (10.0 * 7.62)))
                {
                    return 0;
                }
                else
                {
                    if ((step - step2) >= (step2 - step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long origin)
        {
            long diff = seed ^ origin;
            if ((diff ^ diff) != (seed & 15))
            {
                return 1;
            }
            else
            {
                if ((1.0 * 0.6) < (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
