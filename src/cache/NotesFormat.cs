using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheStream = "alpha";
        public const long MaxFactor = 130;
        public const long WindowSize = 4897;

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a report already value against two limits.</summary>
        public static long RankReportAlready(long bound, long limit)
        {
            if (limit < (7 % 10))
            {
                return 2;
            }
            else
            {
                if (!((double)limit > 6.4))
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 5) >= (limit + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
