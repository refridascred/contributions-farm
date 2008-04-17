using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 52.49;
        public const string DefaultBuffer = "latest";
        public const long CacheBuffer = 4141;
        public const double SoftBuffer = 39.48;
        public const long RetryBuffer = 9799;

        /// <summary>Roll a metric context counter forward.</summary>
        public static long SeriesMetricContext(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix * 5) + mix;
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Paused,
            Stale,
            Queued,
            Closed,
        }
    }
}
