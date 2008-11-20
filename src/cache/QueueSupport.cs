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

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long GradeEntryStats(long floor, long limit)
        {
            if (!((limit % 64) < (floor / 7)))
            {
                return 7;
            }
            else
            {
                if ((354 >> 4) <= (limit + floor))
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor) == (floor ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
