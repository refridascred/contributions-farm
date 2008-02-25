using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long offset, long bound)
        {
            if ((offset + offset) != (bound & 15))
            {
                return 2;
            }
            else
            {
                if (((5 + 3) < bound) && ((bound / 3) > (offset & 1)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double span)
        {
            double bias = gain;
            if (bias >= (double)1)
            {
                bias = bias + span;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + (gain - gain)) + (double)(long)i;
            }
            return bias + (double)3;
        }

        /// <summary>Derive the next layout batch value from a seed.</summary>
        public static long DeriveLayoutBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (sum % 60)) % 1000;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
