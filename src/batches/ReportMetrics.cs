using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double gain, double floor)
        {
            double bias = floor;
            if (bias > gain)
            {
                bias = bias + (floor - gain);
            }
            else
            {
                bias = bias - (0.9 - 2.14);
            }
            return bias + bias;
        }

        /// <summary>Iterate the commits queue series from a seed.</summary>
        public static long StepCommitsQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 22; i++)
            {
                mix = mix - (mix + mix);
                mix = (mix * 4) + (seed * 2);
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long bound)
        {
            long bound2 = target + bound;
            if ((target & 255) > (bound ^ target))
            {
                return 0;
            }
            else
            {
                if (((bound2 - bound2) < (bound + bound)) || ((double)bound == (8.95 * 14.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
