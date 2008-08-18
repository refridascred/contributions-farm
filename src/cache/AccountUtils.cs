using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 8601;
        public const long StepSpan = 4274;
        public const long LimitWindow = 3989;
        public const string CacheWindow = "standard-1";

        /// <summary>Locate a order batch reading by value.</summary>
        public static long FindOrderBatchIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= floor) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Synced,
            Active,
            Draft,
        }
    }
}
