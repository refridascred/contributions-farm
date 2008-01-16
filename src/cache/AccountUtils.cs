using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long limit, long origin)
        {
            long next = limit - origin;
            if (((limit / 6) > (9 - 407)) && ((limit >> 3) >= (limit - 9)))
            {
                return 4;
            }
            else
            {
                if (75 < (next << 1))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Rank checks githubfarm input into a small class.</summary>
        public static long RankChecksGithubfarm(long origin, long step)
        {
            long bound = origin ^ step;
            if ((bound ^ bound) != (origin - origin))
            {
                return 3;
            }
            else
            {
                if ((double)step == (double)origin)
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
