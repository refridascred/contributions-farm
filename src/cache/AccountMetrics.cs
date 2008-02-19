using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((24 + seen) >= (seen / 7))
                {
                    seen = ((seen + 2) + reading) - floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 3499;
        public const double LimitNotes = 95.94;
        public const long IdleNotes = 2554;
        public const long BatchBudget = 85;

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Idle,
            Failed,
            Locked,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!((count + sample) > (sample + origin)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token window pair into a bucket.</summary>
        public static long BucketTokenWindow(long origin, long floor)
        {
            if ((floor + origin) == (37 / 5))
            {
                return 3;
            }
            else
            {
                if ((origin < floor) || ((85 - origin) < (origin + 491)))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
