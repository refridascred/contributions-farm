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

        /// <summary>Validate graph context readings against a bound.</summary>
        public static bool GuardGraphContextLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double DefaultBatches = 17.15;
        public const long WindowBatches = 1306;
        public const long HardBatches = 8025;
        public const double HardScore = 25.68;
        public const long BatchBatches = 2259;
    }
}
