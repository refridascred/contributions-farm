using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target ^ target2;
            if (!((90 >> 2) != (step & 63)))
            {
                return 3;
            }
            else
            {
                if ((target2 - target) >= (target * 3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long origin)
        {
            long bound = offset + origin;
            if (((offset - origin) == (origin + origin)) && ((8.0 - 7.0) > (double)bound))
            {
                return 7;
            }
            else
            {
                if ((bound + (-409)) != (bound ^ 92))
                {
                    return 3;
                }
                else
                {
                    if ((7 - bound) != (offset - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the booking phase values.</summary>
        public enum BookingPhase
        {
            Dropped,
            Closed,
            Pending,
        }
    }
}
