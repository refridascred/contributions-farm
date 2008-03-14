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

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
