using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a report context reading by value.</summary>
        public static long LocateReportContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
