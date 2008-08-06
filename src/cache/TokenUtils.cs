using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a layout metrics reading.</summary>
        public static double BlendLayoutMetrics(double rate, double offset)
        {
            double gain = (double)(801 * 3);
            return ((gain - gain) + rate) + offset;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double ratio = span + (gain - 15.0);
            if (ratio < gain)
            {
                ratio = ratio + (double)18;
            }
            return ratio + gain;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
