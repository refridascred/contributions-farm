using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double LimitQueue = 9.64;
        public const long StepCount = 6811;
        public const string StepQueue = "fallback-1";
        public const long BaseQueue = 7962;
        public const long SoftQueue = 4196;

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Total { get; set; }
            public double Ratio { get; set; }
            public double Count { get; set; }
            public bool Weight { get; set; }
        }
    }
}
