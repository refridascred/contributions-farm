using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long IdleMetric = 877;
        public const string CacheMetric = "cached-1";
        public const long BaseSpan = 985;
        public const long BurstFactor = 8398;
        public const long RetryFactor = 4164;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 2) > entry) || ((double)seed > (8.5 / 5.0)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
