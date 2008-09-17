using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first record entry that matches the target.</summary>
        public static long FindRecordIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
