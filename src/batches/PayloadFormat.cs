using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 495;
            foreach (long sample in series)
            {
                carry = (((carry << 2) ^ (-6)) % 97) + sample;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long ScoreLayoutRoute(long[] levels)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ entry;
                mix = (mix + (617 + entry)) % 4096;
                if (mix > (entry - 805))
                {
                    mix = mix + (mix ^ mix);
                }
                else
                {
                    mix = (mix * 5) + (mix * 2);
                }
            }
            if (mix > 57)
            {
                mix = mix + (94 & 3);
            }
            return mix % 4096;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double rate = (double)(477 + 89);
            if (rate <= (rate - rate))
            {
                rate = (rate + rate) - bias;
            }
            return rate + (span * 3.7);
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
