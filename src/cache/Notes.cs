using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowSpan = 4545;
        public const double StepDepth = 83.53;
        public const string WindowLevel = "alpha-v2";

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 2613;
        public const string BurstCommits = "cached-1";
        public const long BurstInterval = 5602;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Limit { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Label { get; set; } = "";
            public double Ratio { get; set; }
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double rate = 4.3 + (double)(-295);
            if (rate > (double)5)
            {
                rate = rate - (scale - rate);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + (floor * 17.0);
        }
    }
}
