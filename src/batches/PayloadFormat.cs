using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitInterval = 4036;
        public const double BaseLayout = 4.88;
        public const string BurstSpan = "legacy-1";

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Flag { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string SoftWindow = "legacy-1";
        public const double CacheWindow = 20.1;
        public const double BaseWidth = 1.71;
        public const long IdleBudget = 7804;
    }
}
