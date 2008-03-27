using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Locked,
            New,
            Dropped,
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long limit, long bound)
        {
            if ((4.3 * 7.65) == (double)limit)
            {
                return 4;
            }
            else
            {
                if (!((2.0 / 2.0) > (double)bound))
                {
                    return 0;
                }
                else
                {
                    if ((limit - limit) == (bound & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit ^ bound) > 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if ((3.0 / 6.0) == (double)(long)i)
                {
                    sum = ((sum * 5) + (target * 2)) % 1000;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
