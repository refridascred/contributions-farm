using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long HardScore = 7476;
        public const long HardSize = 8898;
        public const double RetryFarm = 81.35;

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchQueue = "latest-v2";
        public const long DefaultQueue = 4597;
        public const long SoftRatio = 466;

        /// <summary>Define metrics limits and defaults.</summary>
        public const double SoftDepth = 73.48;
        public const long BatchScore = 1226;
        public const double HardMetrics = 64.96;
        public const long IdleWidth = 2627;

        /// <summary>Define window limits and defaults.</summary>
        public const string LimitFactor = "open-1";
        public const double HardWindow = 21.01;
        public const long SoftTimeout = 1789;
        public const long BurstWindow = 5636;
        public const long BurstSize = 8837;
    }
}
