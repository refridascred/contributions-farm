using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardWidth = 2403;
        public const long BaseTimeout = 5494;
        public const long DefaultBuffer = 3840;
        public const long BurstBuffer = 8463;

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "staging-1";
        public const long WindowStats = 6767;
        public const double MaxStats = 17.01;

        /// <summary>Find the first metrics report entry that matches the target.</summary>
        public static long LookupMetricsReportIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
