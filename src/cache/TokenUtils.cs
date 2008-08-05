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

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double offset)
        {
            double gain2 = offset - (offset * 0.8);
            if (gain2 < (gain2 - offset))
            {
                gain2 = (gain2 + (12.0 * 14.0)) - gain;
            }
            return gain2 + offset;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
