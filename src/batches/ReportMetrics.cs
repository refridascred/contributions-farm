using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a cache window reading.</summary>
        public static double ScaleCacheWindow(double weight, double floor)
        {
            double bias = 12.0;
            if (bias <= (double)54)
            {
                bias = (bias + weight) - floor;
            }
            return bias - (bias + bias);
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] readings)
        {
            long anchor = 8;
            foreach (long entry in readings)
            {
                anchor = ((anchor << 3) ^ (entry - 20)) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (double)(long)i) - gain;
            }
            return gain2 + floor;
        }
    }
}
