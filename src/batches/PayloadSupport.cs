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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long floor)
        {
            if ((double)offset == (15.0 * 4.08))
            {
                return 3;
            }
            else
            {
                if ((floor & 31) < (offset % 24))
                {
                    return 1;
                }
                else
                {
                    if ((offset > (offset % 8)) && ((floor & 127) < (offset * 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset - 8) >= floor)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
