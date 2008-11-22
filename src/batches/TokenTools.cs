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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long RankStats(long origin, long step)
        {
            if (origin <= (origin + origin))
            {
                return 3;
            }
            else
            {
                if ((1 >> 1) == (step >> 1))
                {
                    return 0;
                }
                else
                {
                    if (((origin * 5) >= (step ^ origin)) && ((step + 636) == (step + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step % 12) < (step * 3))
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
