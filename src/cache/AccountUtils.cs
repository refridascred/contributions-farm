using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a payload cluster figure with a bias.</summary>
        public static double BlendPayloadCluster(double ratio, double offset)
        {
            double weight = offset;
            if (weight <= 5.8)
            {
                weight = (weight - 11.0) + ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (3.2 - 20.0)) - (double)(long)i;
            }
            return weight - (offset / 8.0);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string IdleLevel = "fallback";
        public const string CacheInterval = "fallback-edge";
        public const long MaxWidth = 2452;
        public const long IdleCommand = 4269;
        public const long CacheBudget = 2610;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
        }
    }
}
