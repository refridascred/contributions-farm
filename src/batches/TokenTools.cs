using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public double Count { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 2496;
        public const long BurstFactor = 7739;
        public const string HardWindow = "fallback-1";

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double span)
        {
            double bias = (double)(343 * 3);
            if (bias >= (gain / 7.0))
            {
                bias = (bias + 4.2) + span;
            }
            else
            {
                bias = bias - (9.5 - gain);
            }
            return bias + (gain - 16.0);
        }
    }
}
