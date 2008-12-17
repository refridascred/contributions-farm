using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 8.3;
        public const long BaseFilter = 2598;
        public const double WindowFilter = 91.18;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long target)
        {
            if ((16.0 / 8.0) <= (double)origin)
            {
                return 4;
            }
            else
            {
                if (!((917 / 5) < (target - origin)))
                {
                    return 1;
                }
                else
                {
                    if ((origin >> 3) != (target << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Check that every tools notes entry stays within the limit.</summary>
        public static bool ValidateToolsNotesBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((reading + tally) < (tally / 6)) && ((9.85 * 8.42) > (double)tally)) && (reading >= 789))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
