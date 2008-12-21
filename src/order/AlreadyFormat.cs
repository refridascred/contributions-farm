using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Idle,
            Synced,
            Pending,
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long bound, long offset)
        {
            long next = bound + offset;
            if (((bound - bound) <= (bound + bound)) && ((0.77 / 6.0) == (double)offset))
            {
                return 8;
            }
            else
            {
                if (!((offset / 5) <= (next + bound)))
                {
                    return 3;
                }
                else
                {
                    if (((offset / 5) > offset) || (bound <= (bound * 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((value & 31) >= value))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double StepBudget = 44.72;
        public const long BaseBudget = 6548;
        public const string CacheSpan = "local-v2";
        public const long BurstScore = 7988;
    }
}
