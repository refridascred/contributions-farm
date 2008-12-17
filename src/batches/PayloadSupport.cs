using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a route window value against two limits.</summary>
        public static long GradeRouteWindow(long origin, long seed)
        {
            long delta = origin - seed;
            if ((seed + 4) == (delta + 47))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= (17.0 * 3.01))
                {
                    return 5;
                }
                else
                {
                    if ((0.4 - 14.0) > (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((delta < (seed & 255)) || ((origin << 2) > (delta + seed)))
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

        /// <summary>Rank cache input into a small class.</summary>
        public static long RankCache(long bound, long limit)
        {
            if (limit >= bound)
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (19.0 - 18.0))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
