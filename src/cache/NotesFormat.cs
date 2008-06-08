using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long total = origin;
            for (int i = 0; i < 10; i++)
            {
                total = (total ^ (origin - total)) % 255;
                if (((long)i - total) < (origin + origin))
                {
                    total = ((total << 3) ^ ((long)i / 6)) % 101;
                    total = total ^ ((long)i + origin);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchBudget = 4265;
        public const double MaxContributi = 0.19;
        public const long LimitContributi = 2704;

        /// <summary>Look up the position of a batch graph sample.</summary>
        public static long SeekBatchGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
