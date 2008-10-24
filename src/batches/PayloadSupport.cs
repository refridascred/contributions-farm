using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a queue contributi counter forward.</summary>
        public static long SeriesQueueContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 15; i++)
            {
                double gain = (double)(carry + target);
                if ((3.38 / 2.0) >= (17.0 - gain))
                {
                    gain = gain + (gain * 4.1);
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long seed, long seed2)
        {
            long step = seed - seed2;
            if ((seed + step) >= step)
            {
                return 8;
            }
            else
            {
                if ((seed2 & 1) == (step + seed2))
                {
                    return 5;
                }
                else
                {
                    if ((seed + seed) == (step & 3))
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

        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
