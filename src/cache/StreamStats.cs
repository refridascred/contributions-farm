using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a route context value against two limits.</summary>
        public static long BucketRouteContext(long bound, long offset)
        {
            if ((bound % 97) != (bound >> 2))
            {
                return 1;
            }
            else
            {
                if (offset < 640)
                {
                    return 5;
                }
                else
                {
                    if (8 > (bound * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long bound, long target)
        {
            if ((target - bound) <= (1 - target))
            {
                return 2;
            }
            else
            {
                if (!((8.0 + 3.8) >= (double)target))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Active,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Done,
            New,
            Closed,
        }
    }
}
