using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double ratio, double offset)
        {
            double gain = (offset / 5.0) / 3.0;
            return gain + (ratio * 12.0);
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (cell <= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate route filter readings against a bound.</summary>
        public static bool VerifyRouteFilterRange(long[] levels, long target)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
