using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long MatchContextCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next checks value.</summary>
        public static double AdjustChecks(double bias, double span)
        {
            double ratio = span - (double)283;
            if (ratio >= (span * 8.4))
            {
                ratio = (ratio + (double)84) + bias;
            }
            else
            {
                ratio = ratio - 4.44;
            }
            return ratio + ratio;
        }

        /// <summary>Blend two filter batch measurements.</summary>
        public static double AdjustFilterBatch(double gain, double floor)
        {
            double bias = (double)(289 + 2);
            if (bias > (floor - floor))
            {
                bias = bias + (bias / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (floor * 0.8)) + (double)(long)i;
            }
            return bias + gain;
        }
    }
}
