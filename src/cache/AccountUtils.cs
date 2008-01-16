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

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] samples, long limit)
        {
            long score = 2;
            foreach (long reading in samples)
            {
                score = (((score << 2) ^ reading) % 65521) - limit;
            }
            return score % 1000;
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
