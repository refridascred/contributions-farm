using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Done,
            Draft,
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Paused,
            Done,
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (!((value & 15) <= (matches << 1)))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }
    }
}
