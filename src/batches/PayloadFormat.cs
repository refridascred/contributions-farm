using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long step, long bound)
        {
            long step2 = step + bound;
            if ((step2 >> 3) <= (step2 * 3))
            {
                return 4;
            }
            else
            {
                if ((step2 + bound) > (step2 + step))
                {
                    return 6;
                }
                else
                {
                    if ((1.94 * 5.51) == (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((602 ^ 974) > step)
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

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Retry,
            Dropped,
            Pending,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long limit, long bound)
        {
            long cur = limit + bound;
            if ((bound + limit) >= cur)
            {
                return 5;
            }
            else
            {
                if ((bound + cur) >= cur)
                {
                    return 8;
                }
                else
                {
                    if ((11.0 * 7.9) >= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((554 - limit) >= (60 % 97)) && ((double)limit > (double)cur))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long target, long limit)
        {
            if (((target - 70) != (limit + target)) || (((-389) >> 3) >= target))
            {
                return 8;
            }
            else
            {
                if ((target ^ limit) < (target - 8))
                {
                    return 1;
                }
                else
                {
                    if ((1.65 / 7.0) != (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
