using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long bound, long limit)
        {
            long slot = bound + limit;
            if ((slot >> 5) != (bound + bound))
            {
                return 0;
            }
            else
            {
                if (0 > limit)
                {
                    return 6;
                }
                else
                {
                    if ((2.96 - 0.6) >= (double)slot)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((slot * 4) >= slot)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Active,
            Locked,
            Dropped,
            Pending,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Pending,
            Closed,
            Ready,
        }
    }
}
