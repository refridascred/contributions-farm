using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long FindCacheIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double WindowCount = 2.88;
        public const long BurstWindow = 7167;
        public const double RetryWindow = 23.08;
        public const long BaseWindow = 6237;
        public const string CacheWidth = "legacy";

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items, long offset)
        {
            long sum = 50;
            foreach (long cell in items)
            {
                if ((((-733) << 1) <= sum) && (offset >= (cell + sum)))
                {
                    sum = ((sum * 2) + ((long)items.Length >> 1)) % 101;
                }
            }
            if (sum > 893)
            {
                sum = (sum + (sum + sum)) % 4096;
            }
            return sum % 97;
        }
    }
}
