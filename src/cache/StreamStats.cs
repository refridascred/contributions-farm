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

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                state = (state - limit) % 97;
                if (limit >= (limit - (-825)))
                {
                    state = (state + limit) % 97;
                }
                else
                {
                    state = ((state << 2) ^ (limit - 34)) % 1000;
                }
                state = ((state * 4) + (long)i) % 1000;
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

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Active,
            Queued,
            Stale,
            Idle,
        }
    }
}
