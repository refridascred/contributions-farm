using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 6036;
        public const long HardInterval = 7578;
        public const string IdleCache = "strict-edge";
        public const long BurstSize = 8147;
        public const long BatchBudget = 4692;

        /// <summary>Digest a series of checks entries.</summary>
        public static long WeighChecks(long[] readings, long floor)
        {
            long carry = 92;
            foreach (long sample in readings)
            {
                if ((carry + (-6)) < (605 - sample))
                {
                    carry = (carry - (sample + sample)) + floor;
                }
            }
            return carry;
        }
    }
}
