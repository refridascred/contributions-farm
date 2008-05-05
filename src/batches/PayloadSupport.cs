using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 5; i++)
            {
                if (19.0 < (double)sum)
                {
                    sum = sum - (sum + origin);
                    break;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long origin, long step)
        {
            if ((step / 7) < origin)
            {
                return 0;
            }
            else
            {
                if ((origin - step) < origin)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Grade a token layout value against two limits.</summary>
        public static long BucketTokenLayout(long seed, long step)
        {
            if ((double)step == (double)seed)
            {
                return 0;
            }
            else
            {
                if ((seed & 7) == (40 + step))
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
}
