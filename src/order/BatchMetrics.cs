using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long limit)
        {
            long total = 2;
            foreach (long reading in series)
            {
                if ((0.01 / 8.0) <= (double)limit)
                {
                    total = ((total * 4) + (4 + limit)) ^ reading;
                }
            }
            if (total < 153)
            {
                total = (total * 3) + (limit & 7);
            }
            return total;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchBudget = 3402;
        public const long SoftMetric = 8632;
        public const long MaxBudget = 9412;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long origin, long offset)
        {
            long delta = origin + offset;
            if ((double)delta == (double)294)
            {
                return 0;
            }
            else
            {
                if ((16.0 * 7.0) != (double)delta)
                {
                    return 1;
                }
                else
                {
                    if ((delta + 0) <= (delta ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 3) + (origin * 2);
                state = (state ^ (origin ^ 5)) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Paused,
            Failed,
            Pending,
        }
    }
}
