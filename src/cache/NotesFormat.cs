using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a context command value against two limits.</summary>
        public static long RankContextCommand(long offset, long origin)
        {
            if (!((offset << 1) < offset))
            {
                return 2;
            }
            else
            {
                if ((981 ^ offset) < (origin >> 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            New,
            Pending,
            Retry,
        }
    }
}
