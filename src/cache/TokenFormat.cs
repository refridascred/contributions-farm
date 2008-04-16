using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Idle,
            New,
            Synced,
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double bias, double span)
        {
            double mean = (double)990 / 6.0;
            if (mean < 8.6)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (bias - span);
            }
            return mean - (bias * 8.14);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 8262;
        public const double BaseCount = 44.42;
        public const long SoftDepth = 5335;
    }
}
