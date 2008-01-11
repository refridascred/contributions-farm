using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double mean = (double)(492 << 2);
            return ((mean + (0.6 / 2.0)) + scale) + floor;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Stamp { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 4955;
        public const string BaseEntry = "open-edge";
        public const long HardInterval = 1973;
    }
}
