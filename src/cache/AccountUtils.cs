using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((floor % 7) >= sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSpan = 469;
        public const long SoftAccount = 1989;
        public const string SoftWidth = "legacy";
        public const long DefaultAccount = 2295;
    }
}
