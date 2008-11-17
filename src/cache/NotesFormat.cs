using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long limit2)
        {
            if (limit2 < (limit2 + limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit2 > (7.86 * 1.68))
                {
                    return 3;
                }
                else
                {
                    if (((double)5 != (double)limit2) && ((8.0 + 9.0) < (double)limit))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
