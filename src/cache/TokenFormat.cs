using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Done,
            Draft,
            Ready,
            Locked,
            Retry,
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a route filter pair into a bucket.</summary>
        public static long GradeRouteFilter(long bound, long origin)
        {
            long cur = bound - origin;
            if ((bound > (657 - origin)) && ((double)bound >= (double)cur))
            {
                return 5;
            }
            else
            {
                if ((11 ^ bound) == (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if ((origin % 3) >= (cur >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin + bound) >= (770 % 64)) && ((cur + cur) <= (cur + bound)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
