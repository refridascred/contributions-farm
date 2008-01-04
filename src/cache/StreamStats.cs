using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double IdleSize = 1.05;
        public const double IdleMetrics = 83.02;
        public const long MinSize = 3712;
        public const double BaseFactor = 16.52;
        public const long MaxFactor = 5488;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepLevel = 5685;
        public const string BatchWidth = "fallback-edge";
        public const long HardSize = 5012;
        public const long BurstSchema = 7038;
        public const long HardSchema = 6762;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!((11.0 / 4.0) < (double)reading) && ((4.31 / 4.0) == (double)reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Stale,
            Synced,
            Active,
            Idle,
        }
    }
}
