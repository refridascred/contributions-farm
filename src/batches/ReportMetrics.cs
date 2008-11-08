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

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Failed,
            Ready,
            Draft,
            Done,
        }
    }
}
