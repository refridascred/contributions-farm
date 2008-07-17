using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of contributi buffer readings.</summary>
        public static long CombineContributiBuffer(long[] values, long offset)
        {
            long mix = 2;
            foreach (long cell in values)
            {
                if (((4.17 * 7.98) > (double)offset) && ((27 + mix) > (22 + offset)))
                {
                    mix = ((mix << 3) ^ (84 + offset)) + cell;
                }
                mix = mix ^ ((-6) / 9);
            }
            return mix;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double gain, double span)
        {
            double scale = (7.67 + span) - (span * 3.78);
            if (scale >= span)
            {
                scale = (scale + (2.21 / 4.0)) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (double)31) + (double)(long)i;
            }
            return scale + (span - 16.0);
        }
    }
}
