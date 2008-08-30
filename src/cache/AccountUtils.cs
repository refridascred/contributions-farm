using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long origin, long origin2)
        {
            if ((origin2 + origin2) >= origin)
            {
                return 2;
            }
            else
            {
                if (origin2 >= (origin >> 5))
                {
                    return 5;
                }
                else
                {
                    if (4.8 < (double)origin2)
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin2 <= (origin2 + origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Idle,
            Paused,
            New,
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Locked,
            Dropped,
            Stale,
            Idle,
            Active,
        }
    }
}
