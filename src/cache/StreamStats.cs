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

        /// <summary>Fold a list of already stats readings.</summary>
        public static long FoldAlreadyStats(long[] series)
        {
            long state = 0;
            foreach (long value in series)
            {
                state = ((state << 2) ^ (state * 3)) + value;
            }
            return state;
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

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!!((double)seen < (13.0 + 17.0)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
