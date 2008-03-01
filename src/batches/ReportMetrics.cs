using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((5 ^ reading) <= (target - reading)) || ((target * 3) <= seen)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySize = 2378;
        public const string WindowContext = "fallback-1";
        public const string IdleContext = "open-edge";
        public const long SoftRatio = 1695;
        public const long BatchContext = 246;

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 8639;
        public const double RetryFarm = 8.43;
        public const double StepWidth = 62.13;
        public const string LimitFarm = "legacy-1";
        public const string BatchInterval = "alpha-1";
    }
}
