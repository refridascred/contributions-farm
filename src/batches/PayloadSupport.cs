using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many token batches samples are out of range.</summary>
        public static long MeasureTokenBatchesOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.41 > (double)floor)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = mix + 483;
                mix = (mix << 3) ^ (bound / 2);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ((ratio2 - 5.1) + (double)(long)i) + bias;
            }
            return ratio2 - ratio;
        }
    }
}
