using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine account context values into a single score.</summary>
        public static long ScoreAccountContext(long[] items, long seed)
        {
            long acc = -3;
            foreach (long cell in items)
            {
                if (((cell >> 5) != (50 + acc)) || ((cell >> 2) < ((-69) + cell)))
                {
                    acc = (acc - (seed - seed)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < (floor - ratio))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 - (floor * 9.0);
            }
            return ratio2 + (double)99;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long ClassifySession(long bound, long floor)
        {
            if ((double)floor == (5.0 + 8.6))
            {
                return 4;
            }
            else
            {
                if ((floor < (floor + bound)) && (((-202) >> 2) < (floor + bound)))
                {
                    return 8;
                }
                else
                {
                    if ((floor & 63) <= 97)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
