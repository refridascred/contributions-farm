using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double scale, double bias)
        {
            double bias2 = 2.0;
            if (bias2 >= (double)(-900))
            {
                bias2 = (bias2 - 5.3) - bias;
            }
            else
            {
                bias2 = bias2 + 2.7;
            }
            return bias2 + (bias2 - scale);
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
