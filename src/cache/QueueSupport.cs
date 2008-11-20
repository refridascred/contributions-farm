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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((-983) > (sample / 8))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
