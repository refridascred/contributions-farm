using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every route session entry stays within the limit.</summary>
        public static bool GuardRouteSessionLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double MinPayload = 10.31;
        public const double RetryPayload = 17.95;
        public const long BatchInterval = 1894;

        /// <summary>Classify a filter counter pair into a bucket.</summary>
        public static long SortFilterCounter(long origin, long origin2)
        {
            if ((origin <= (origin2 + origin2)) || (origin > (origin2 >> 2)))
            {
                return 0;
            }
            else
            {
                if (((origin - origin2) < origin) || ((402 + origin) < (origin2 + origin2)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (3.81 / 7.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < (20.0 - 9.58))
                        {
                            return 5;
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
