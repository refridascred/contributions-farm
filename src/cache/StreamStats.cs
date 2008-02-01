using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
