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

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double scale, double span)
        {
            double gain = (scale - scale) + (span * 5.5);
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (scale - 5.88)) + (double)(long)i;
            }
            return gain - (double)146;
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
