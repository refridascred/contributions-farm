using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Stale,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            New,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            long prev = bound + step;
            if (bound >= ((-207) - bound))
            {
                return 6;
            }
            else
            {
                if (!((prev - 4) == (bound - 3)))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
