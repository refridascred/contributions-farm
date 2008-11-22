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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long BucketPayload(long offset, long step)
        {
            if (step > (offset + step))
            {
                return 8;
            }
            else
            {
                if ((step + offset) > (step + step))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) < step)
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

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Synced,
            Draft,
            Locked,
        }
    }
}
