using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxWidth = 948;
        public const long HardEntry = 3803;
        public const long StepRatio = 3136;
        public const long MinRatio = 1102;
        public const double WindowCount = 54.37;

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
