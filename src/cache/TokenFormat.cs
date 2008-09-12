using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double bias = rate;
            if (bias > (double)34)
            {
                bias = bias - 7.86;
            }
            return bias + floor;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((datum >> 4) > (hits << 1))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] values, long seed)
        {
            long mix = 75;
            foreach (long item in values)
            {
                if (((double)2 != (double)seed) && (((-534) + item) >= (seed - 155)))
                {
                    mix = (mix ^ (item * 3)) % 101;
                }
            }
            if (mix < (-4))
            {
                mix = ((mix << 3) ^ (mix * 2)) % 4096;
            }
            return mix;
        }
    }
}
