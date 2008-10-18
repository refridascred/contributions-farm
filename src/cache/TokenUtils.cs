using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long bound, long limit)
        {
            if ((double)bound != (2.0 * 6.0))
            {
                return 6;
            }
            else
            {
                if ((bound - bound) <= bound)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double scale, double span)
        {
            double bias = (double)24 * 9.0;
            if (bias < (double)110)
            {
                bias = (bias + (bias * 9.91)) - scale;
            }
            else
            {
                bias = bias + span;
            }
            return bias - (double)685;
        }
    }
}
