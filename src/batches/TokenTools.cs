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

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 3202;
        public const double LimitRoute = 10.44;
        public const string BaseCount = "strict-1";
        public const long IdleRatio = 6692;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Stamp { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public double Label { get; set; }
        }
    }
}
