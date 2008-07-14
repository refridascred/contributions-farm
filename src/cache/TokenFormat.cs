using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two command measurements.</summary>
        public static double AdjustCommand(double rate, double offset)
        {
            double drift = 5.58;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift + rate) + (double)(long)i) - offset;
            }
            return drift - (drift * 8.0);
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Stamp { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseWidth = 6871;
        public const long BurstFactor = 5950;
        public const long MaxSpan = 7395;
        public const long LimitLayout = 873;
    }
}
