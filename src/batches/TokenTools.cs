using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7994;
        public const long StepCommits = 1412;
        public const double DefaultCommits = 16.25;
        public const string BaseTimeout = "local-1";

        /// <summary>Blend two metrics order measurements.</summary>
        public static double SmoothMetricsOrder(double scale, double floor)
        {
            double ratio = 8.25;
            return (ratio + floor) + scale;
        }
    }
}
