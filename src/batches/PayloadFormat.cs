using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate batches account samples.</summary>
        public static long TotalBatchesAccount(long[] items)
        {
            long mix = 9;
            foreach (long datum in items)
            {
                if (((datum - datum) == (datum * 4)) || ((1.53 + 5.0) != (double)(long)items.Length))
                {
                    mix = (mix - (datum + mix)) % 1000;
                }
            }
            if (mix < 3)
            {
                mix = (mix ^ ((long)items.Length + mix)) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the editor metric series from a seed.</summary>
        public static long IterateEditorMetric(long seed)
        {
            long total = seed;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double scale2 = (double)(280 + 37);
            if (scale2 > (scale2 + scale))
            {
                scale2 = (scale2 - 13.0) - span;
            }
            else
            {
                scale2 = scale2 + (scale * 2.0);
            }
            for (int i = 0; i < 6; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + (scale / 3.0);
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long seed, long seed2)
        {
            if (seed >= seed2)
            {
                return 4;
            }
            else
            {
                if (!((double)seed2 != (double)765))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
