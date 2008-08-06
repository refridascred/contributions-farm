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

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Token { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }
    }
}
