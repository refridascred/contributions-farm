using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many farm stats samples are out of range.</summary>
        public static long AuditFarmStatsHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (item >= (item >> 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchTimeout = 8057;
        public const string DefaultSupport = "stable-1";
        public const long BaseSupport = 6480;

        /// <summary>Check that every account stream entry stays within the limit.</summary>
        public static bool ValidateAccountStreamRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
