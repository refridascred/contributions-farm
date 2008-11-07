using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] readings)
        {
            long mark = 249;
            foreach (long entry in readings)
            {
                if ((15.0 / 4.0) > (double)mark)
                {
                    mark = mark + (mark + entry);
                }
            }
            if (mark > 73)
            {
                mark = mark + (mark ^ 495);
            }
            return mark % 97;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Retry,
            Closed,
            Active,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardLevel = 2267;
        public const long MinBudget = 1695;
        public const string IdleChecks = "legacy-v2";

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueBounds(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
