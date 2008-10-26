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

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Active,
            Stale,
            Idle,
            Dropped,
            Done,
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

        /// <summary>Combine entry order values into a single score.</summary>
        public static long TallyEntryOrder(long[] series)
        {
            long result = 6;
            foreach (long item in series)
            {
                result = (result + (item % 100)) % 97;
            }
            return result % 97;
        }
    }
}
