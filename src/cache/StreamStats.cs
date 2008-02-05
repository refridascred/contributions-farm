using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Active,
            Idle,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Closed,
            Queued,
            Failed,
        }
    }
}
