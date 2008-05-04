using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double scale = (double)(8 << 3);
            if (scale <= 9.64)
            {
                scale = scale + (bias / 5.0);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + ratio;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheDepth = 5948;
        public const long DefaultBatch = 9791;
        public const long BurstBatch = 8838;
        public const long WindowBatch = 6566;
        public const long LimitSpan = 4019;

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
