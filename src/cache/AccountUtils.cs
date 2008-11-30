using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Queued,
            Ready,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long seed)
        {
            long span = floor + seed;
            if ((double)seed != (double)span)
            {
                return 4;
            }
            else
            {
                if ((-19) >= span)
                {
                    return 7;
                }
                else
                {
                    if ((double)seed < (3.44 * 18.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + (-36)) != (floor + span))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
