using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((545 << 3) <= (item * 4))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 2.14;
        public const string BatchRoute = "fallback";
        public const long WindowRoute = 3825;
        public const double BurstRoute = 59.0;

        /// <summary>Validate report command readings against a bound.</summary>
        public static bool GuardReportCommandBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long SortPayload(long offset, long origin)
        {
            if ((19.0 + 0.04) >= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((2.94 + 2.0) < (double)origin)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((floor ^ floor) != (anchor + (long)i))
                {
                    break;
                }
                anchor = (anchor ^ (58 >> 3)) % 1000;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
