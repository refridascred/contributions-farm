using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first report schema entry that matches the target.</summary>
        public static long LookupReportSchemaIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string IdleInterval = "legacy";
        public const long IdleFilter = 5437;
        public const long RetryFilter = 9628;
        public const long BurstCount = 2209;
        public const long BurstLevel = 1589;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry == (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
