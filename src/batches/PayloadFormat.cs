using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long AuditProfileOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((3.8 * 7.83) != (double)cell) && (((matches % 24) != (cell ^ cell)) || ((double)cell < (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandOutliers(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches + 88) < step)
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] readings)
        {
            long state = 23;
            foreach (long entry in readings)
            {
                state = state ^ (state - entry);
            }
            if (state > 4)
            {
                state = ((state * 2) + state) % 97;
            }
            return state;
        }
    }
}
