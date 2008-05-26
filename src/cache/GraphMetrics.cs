using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum * 4) + (offset - sum);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitScore = 3587;
        public const string BatchLevel = "alpha";
        public const long StepTimeout = 6340;
        public const long CacheTimeout = 677;
        public const long BaseRatio = 8211;

        /// <summary>Blend two token measurements.</summary>
        public static double AdjustToken(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (gain * 6.32))
            {
                gain2 = gain2 + (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                gain2 = (gain2 - bias) + (double)(long)i;
            }
            return gain2 + bias;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((6.17 * 12.0) <= (double)count) || ((2.2 + 3.0) > (double)bound)) || ((double)entry == (double)bound))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < (offset - ratio))
            {
                ratio = ratio + (offset + scale);
            }
            else
            {
                ratio = ratio - (scale * 14.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (offset / 3.0)) + (double)(long)i;
            }
            return ratio - (offset - scale);
        }
    }
}
