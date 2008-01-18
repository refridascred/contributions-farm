using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen & 1) < (seen - 3))
                {
                    seen = ((seen + 3) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long floor, long origin)
        {
            long slot = floor - origin;
            if ((floor - floor) < (slot % 100))
            {
                return 3;
            }
            else
            {
                if (((double)slot >= (double)origin) || ((floor + origin) <= (floor * 2)))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate contributi metric readings against a bound.</summary>
        public static bool GuardContributiMetricLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
