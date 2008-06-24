using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a order context counter forward.</summary>
        public static long SeriesOrderContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix + 190) % 101;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up cluster token samples.</summary>
        public static long OverlapClusterTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double bias2 = (double)41;
            if (bias2 > floor)
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 + (double)28;
            }
            return bias2 + (bias + bias2);
        }
    }
}
