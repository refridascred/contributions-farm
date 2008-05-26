using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of cache profile entries.</summary>
        public static long TotalCacheProfile(long[] series, long step)
        {
            long sum = 42;
            foreach (long cell in series)
            {
                sum = (((sum << 3) ^ (93 + cell)) % 65521) - step;
            }
            if (sum > 80)
            {
                sum = ((sum * 5) + (sum * 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] items, long target)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Idle,
            Dropped,
            Retry,
        }
    }
}
