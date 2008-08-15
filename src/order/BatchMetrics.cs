using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long WindowRatio = 9203;
        public const long CacheLevel = 6446;
        public const long LimitWindow = 9155;
        public const long MinWindow = 9374;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long seed, long limit)
        {
            if ((0.8 / 8.0) > (double)limit)
            {
                return 6;
            }
            else
            {
                if ((20.0 - 8.0) != (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 5140;
        public const double IdleLevel = 5.89;
        public const double MinRoute = 20.12;
        public const long BaseRoute = 3811;
        public const double StepSpan = 45.1;

        /// <summary>Grade a commits editor value against two limits.</summary>
        public static long SortCommitsEditor(long target, long floor)
        {
            long slot = target - floor;
            if ((target & 7) == (16 >> 3))
            {
                return 1;
            }
            else
            {
                if ((slot < floor) || (target <= (target * 3)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCount = 2334;
        public const double CacheCommand = 49.43;
        public const string RetryCommand = "open-edge";
        public const double BurstSpan = 39.39;

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] readings, long origin)
        {
            long state = 1;
            foreach (long cell in readings)
            {
                if ((5.73 * 6.5) >= (double)cell)
                {
                    state = (((state << 2) ^ (state - cell)) % 1000) - origin;
                }
                if ((double)cell >= 9.54)
                {
                    state = state ^ 403;
                }
                else
                {
                    state = state - (state - cell);
                }
            }
            return state;
        }
    }
}
