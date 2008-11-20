using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Stale,
            Failed,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 4032;
        public const double RetryLevel = 91.97;
        public const long BaseMetrics = 9507;
        public const double DefaultMetrics = 44.18;
        public const long IdleMetrics = 100;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((step - count) < (datum - count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
