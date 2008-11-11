using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Size { get; set; }
            public double Level { get; set; }
            public double Ratio { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitWidth = "strict-1";
        public const string StepCount = "fallback";
        public const long BurstSupport = 7339;
        public const long BaseLevel = 6877;
        public const string BaseCount = "latest-v2";

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 7071;
        public const double BatchFactor = 43.01;
        public const string LimitChannel = "legacy-1";
        public const double BurstChannel = 63.17;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Retry,
            Failed,
        }
    }
}
