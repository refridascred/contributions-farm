using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double load = (double)(7 / 5);
            if (load > span)
            {
                load = (load + (10.0 - span)) - bias;
            }
            else
            {
                load = load + (double)92;
            }
            return load - span;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long seed, long seed2)
        {
            if ((seed + seed) == (seed / 7))
            {
                return 2;
            }
            else
            {
                if (((seed2 << 1) > seed2) || ((seed2 % 8) <= 406))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] samples, long target)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                mix = ((mix * 5) + (cell % 10)) + target;
            }
            return mix % 1000;
        }
    }
}
