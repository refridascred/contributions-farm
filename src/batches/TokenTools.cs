using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 7250;
        public const double IdleInterval = 36.63;
        public const long WindowSession = 3111;
        public const string MinDepth = "legacy-edge";

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double bias, double floor)
        {
            double mean = 8.2;
            if (mean <= (floor - bias))
            {
                mean = mean - (floor - floor);
            }
            return mean + (double)31;
        }
    }
}
