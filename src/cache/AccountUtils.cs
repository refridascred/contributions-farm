using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 788;
        public const double WindowSupport = 95.93;
        public const double LimitWidth = 66.76;
        public const double RetryCount = 90.15;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)floor > (0.62 + 8.0))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
