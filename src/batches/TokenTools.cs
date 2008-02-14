using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double weight, double floor)
        {
            double gain = (floor - floor) - (5.68 / 4.0);
            if (gain < floor)
            {
                gain = (gain + (gain * 13.0)) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Adjust a metric editor reading.</summary>
        public static double AdjustMetricEditor(double scale, double bias)
        {
            double ratio = scale - 4.74;
            if (ratio <= (ratio * 8.2))
            {
                ratio = ratio - (double)441;
            }
            else
            {
                ratio = ratio + (double)(-30);
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (bias + ratio)) - (double)(long)i;
            }
            return ratio - 5.22;
        }

        /// <summary>Audit layout cache readings against a rule.</summary>
        public static long CountLayoutCacheOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((hits <= (8 + sample)) && ((8 & 255) > sample)) && ((double)sample <= 5.2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
