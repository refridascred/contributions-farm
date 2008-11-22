using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long origin, long limit)
        {
            if (((double)limit >= 1.47) && ((2.79 - 17.0) != (double)origin))
            {
                return 8;
            }
            else
            {
                if ((2.6 / 5.0) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit >= (origin - 6)) && ((origin - limit) < (limit ^ 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Idle,
            Ready,
            Active,
            Done,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Draft,
            Locked,
        }
    }
}
