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

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (seen >= (item / 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
