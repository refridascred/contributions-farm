using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double ratio, double offset)
        {
            double scale = (double)(-27) + 6.1;
            if (scale >= ratio)
            {
                scale = (scale + (2.0 * 1.0)) - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 7.0)) + (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double rate2 = (rate + 16.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Look up the position of a metrics route sample.</summary>
        public static long LocateMetricsRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
