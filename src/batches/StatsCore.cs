using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading / 6) < (55 + 755))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry > 4.1)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches < (matches >> 4)) || ((1 ^ matches) < reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = state ^ ((long)i + (long)i);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryOrder = 92.7;
        public const long BurstOrder = 9896;
        public const double WindowOrder = 30.34;
    }
}
