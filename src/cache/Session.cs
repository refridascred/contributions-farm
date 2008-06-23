using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowBudget = 3937;
        public const string DefaultSpan = "stable-v2";
        public const long WindowMetrics = 9179;
        public const string BurstMetrics = "stable-1";
        public const double SoftScore = 22.28;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long target, long origin)
        {
            long diff = target - origin;
            if ((diff + target) <= (target + diff))
            {
                return 3;
            }
            else
            {
                if (((14.0 * 6.0) == (double)diff) && ((3.75 * 2.0) <= (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((93 - target) > target)
                    {
                        return 7;
                    }
                    else
                    {
                        if (diff < (origin - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
