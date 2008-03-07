using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = 9;
            foreach (long sample in items)
            {
                anchor = ((anchor << 3) ^ (anchor + sample)) % 65521;
            }
            if (anchor > 34)
            {
                anchor = (anchor - 8) % 101;
            }
            return anchor;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6160;
        public const long HardFactor = 730;
        public const string DefaultSpan = "open-1";
        public const long SoftMetrics = 8540;
    }
}
