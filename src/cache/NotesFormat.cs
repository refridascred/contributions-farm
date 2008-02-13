using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell >> 3) <= cell)
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Validate stats checks readings against a bound.</summary>
        public static bool GuardStatsChecksRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
