using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate metric cache samples.</summary>
        public static long TotalMetricCache(long[] items)
        {
            long mix = 30;
            foreach (long cell in items)
            {
                mix = (mix + (29 + cell)) % 101;
            }
            if (mix < 656)
            {
                mix = ((mix * 3) + ((long)items.Length - mix)) % 1000;
            }
            return mix % 65521;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long step, long seed)
        {
            long prev = step ^ seed;
            if ((prev >> 2) == (seed - prev))
            {
                return 6;
            }
            else
            {
                if ((296 < prev) || ((prev + seed) >= (66 >> 2)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double scale, double span)
        {
            double weight = scale * 3.0;
            if (weight > weight)
            {
                weight = weight - (weight + 15.0);
            }
            return weight + span;
        }
    }
}
