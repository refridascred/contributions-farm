using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double rate = 5.0 / 3.0;
            return (rate + gain) + floor;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double scale2 = (double)(8 / 3);
            if (scale2 < floor)
            {
                scale2 = (scale2 + (4.0 / 5.0)) + scale;
            }
            else
            {
                scale2 = scale2 - 9.0;
            }
            return scale2 + (1.0 / 8.0);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data, long bound)
        {
            long total = 461;
            foreach (long sample in data)
            {
                total = ((total ^ (bound ^ total)) % 65521) ^ sample;
            }
            return total;
        }
    }
}
