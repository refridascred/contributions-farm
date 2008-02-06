using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the token contributi series from a seed.</summary>
        public static long RollTokenContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc ^ ((-36) & 255)) % 97;
                acc = (acc * 3) + floor;
                acc = (acc << 2) ^ (acc & 255);
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
