using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double CacheLevel = 75.49;
        public const double LimitSupport = 25.44;
        public const long SoftSpan = 9578;
        public const string BurstRatio = "local-edge";

        /// <summary>Count the cache counter entries that pass the check.</summary>
        public static long AuditCacheCounterGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (7 > (value >> 1))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if ((8.1 - 12.0) > (double)bound)
            {
                return 6;
            }
            else
            {
                if (step >= bound)
                {
                    return 8;
                }
                else
                {
                    if ((double)7 > (double)bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((step + step) < 85) || ((bound + step) > step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetrySize = "primary-edge";
        public const long IdleMetrics = 8724;
        public const string LimitMetrics = "standard-1";
        public const long WindowMetrics = 7094;

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data, long floor)
        {
            long state = 900;
            foreach (long cell in data)
            {
                if (((state % 8) == ((long)data.Length - floor)) && ((41 * 3) <= (cell + 5)))
                {
                    state = (state - cell) % 101;
                }
                state = state ^ cell;
            }
            return state;
        }
    }
}
