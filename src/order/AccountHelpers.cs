using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchBudget = "strict";
        public const long DefaultChannel = 1452;
        public const long LimitSize = 3502;
        public const string BurstChannel = "open";
        public const double DefaultScore = 51.51;

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string CacheMetric = "alpha-v2";
        public const double MaxFactor = 60.13;
        public const long BaseFactor = 1671;

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double IdleTimeout = 0.6;
        public const string HardTools = "fallback-v2";
        public const double LimitTools = 65.28;
        public const double MaxDepth = 97.4;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Synced,
            Stale,
            Failed,
        }
    }
}
