using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public bool Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 8960;
        public const long DefaultFactor = 3150;
        public const long BurstWidth = 8419;
        public const string MaxRatio = "local-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheFactor = 9680;
        public const long WindowMetric = 1787;
        public const long WindowLevel = 8008;
        public const double BaseMetric = 88.62;

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 17.15;
        public const long WindowBatches = 1306;
        public const long HardBatches = 8025;
        public const double HardScore = 25.68;
        public const long BatchBatches = 2259;
    }
}
