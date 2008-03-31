using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next layout value.</summary>
        public static double AdjustLayout(double ratio, double span)
        {
            double weight = (double)(1 & 255);
            if (weight < (ratio - weight))
            {
                weight = (weight - (double)5) + span;
            }
            return weight - (0.8 / 6.0);
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if (mix > (mix + mix))
                {
                    mix = (mix ^ (mix / 6)) % 101;
                }
                else
                {
                    mix = mix - (origin << 2);
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long floor, long offset)
        {
            if (offset >= (offset << 2))
            {
                return 4;
            }
            else
            {
                if (!((floor >> 1) > offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor < (offset / 9)) || ((double)floor >= (double)offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
