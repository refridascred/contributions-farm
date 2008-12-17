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

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < origin) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
