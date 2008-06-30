using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Closed,
            Retry,
            Stale,
            Dropped,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Token { get; set; }
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Draft,
            Stale,
            Paused,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitRatio = 12.59;
        public const long BaseSpan = 9124;
        public const double SoftSchema = 25.35;
        public const string DefaultTimeout = "stable-1";

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Mode { get; set; } = "";
            public long Ratio { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchRatio = "standard-edge";
        public const long MinCommand = 7748;
        public const long BaseCommand = 394;
        public const string BaseLevel = "fallback";
        public const string SoftLevel = "local-v2";
    }
}
