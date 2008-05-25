using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many format stream samples are out of range.</summary>
        public static long TallyFormatStreamHits(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry - target) < (entry * 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 9085;
        public const long WindowRoute = 5719;
        public const long BatchSize = 4487;
        public const long BatchRatio = 757;
        public const long BatchCount = 4550;

        /// <summary>Measure how many cluster stats samples are out of range.</summary>
        public static long TallyClusterStatsHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((double)matches == (13.0 + 4.3))
                {
                    matches = ((matches + 2) + datum) + bound;
                }
            }
            return matches;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long seed)
        {
            if (((84 - limit) > seed) || ((seed + limit) >= seed))
            {
                return 7;
            }
            else
            {
                if ((2 / 4) >= (seed & 15))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
