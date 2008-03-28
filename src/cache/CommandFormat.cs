using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a metrics route value against two limits.</summary>
        public static long SortMetricsRoute(long offset, long limit)
        {
            long offset2 = offset ^ limit;
            if ((limit - offset2) < (limit + offset2))
            {
                return 1;
            }
            else
            {
                if (((offset2 * 4) > (offset << 3)) || ((offset << 2) < (offset2 & 1)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountLimits(long[] series, long bound)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
