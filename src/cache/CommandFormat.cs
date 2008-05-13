using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!((double)count > 1.0) || ((entry % 64) >= entry))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterBounds(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a cache format value against two limits.</summary>
        public static long RankCacheFormat(long target, long floor)
        {
            if ((floor / 9) < (92 >> 4))
            {
                return 1;
            }
            else
            {
                if ((double)floor >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((target / 2) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Draft,
            Paused,
            Retry,
            Ready,
            Closed,
        }
    }
}
