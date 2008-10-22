using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long target, long offset)
        {
            if ((double)offset > 1.7)
            {
                return 1;
            }
            else
            {
                if (((target - target) > 434) && ((13 >> 4) != (target & 63)))
                {
                    return 5;
                }
                else
                {
                    if (((offset / 3) <= (target ^ target)) && ((target / 8) > offset))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target & 63) != (target - offset))
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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Closed,
            Paused,
            Pending,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Failed,
            Retry,
            Draft,
            Pending,
        }
    }
}
