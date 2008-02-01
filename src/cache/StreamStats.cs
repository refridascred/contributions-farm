using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a command batch figure with a bias.</summary>
        public static double ScaleCommandBatch(double scale, double span)
        {
            double drift = span + (double)443;
            if (drift > 9.24)
            {
                drift = (drift + (drift / 2.0)) - scale;
            }
            return drift + drift;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 6610;
        public const long DefaultInterval = 6905;
        public const long MaxLevel = 3299;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
