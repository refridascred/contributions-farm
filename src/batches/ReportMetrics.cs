using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftLevel = 20.76;
        public const long LimitQueue = 4180;
        public const double WindowCount = 36.12;
        public const long RetryQueue = 6158;
        public const long IdleQueue = 1952;

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
