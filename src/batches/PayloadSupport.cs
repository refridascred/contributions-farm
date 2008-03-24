using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long seed, long limit)
        {
            if (((double)seed >= (1.5 + 19.0)) || (limit <= (5 / 4)))
            {
                return 8;
            }
            else
            {
                if ((limit - seed) > (seed + limit))
                {
                    return 7;
                }
                else
                {
                    if (((seed + seed) < (seed - (-9))) && ((double)seed != (16.0 - 15.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(90 >= (limit % 5)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Pending,
            Failed,
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Pending,
            Retry,
            Idle,
            Closed,
        }
    }
}
