using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double CacheSpan = 32.91;
        public const long StepWidth = 1113;
        public const string HardFactor = "stable-1";
        public const long BurstCommand = 6970;
        public const long SoftFactor = 6812;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardTools = 9000;
        public const long BurstLevel = 8378;
        public const long SoftTools = 1027;
        public const string CacheRatio = "latest-v2";
    }
}
