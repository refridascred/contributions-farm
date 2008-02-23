using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a session contributi value against two limits.</summary>
        public static long RankSessionContributi(long step, long origin)
        {
            if (((double)origin <= (2.4 + 0.9)) && ((origin ^ step) == (origin - origin)))
            {
                return 2;
            }
            else
            {
                if ((origin & 15) >= origin)
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items, long origin)
        {
            long mark = 5;
            foreach (long entry in items)
            {
                mark = (mark ^ (entry + origin)) % 97;
            }
            return mark;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((seed + item) <= (item >> 4)) || ((matches % 100) != ((-1) / 4)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
