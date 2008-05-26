using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 9285;
        public const string MaxWidth = "fallback-1";
        public const double CacheInterval = 8.95;
        public const long MaxOrder = 1917;
        public const string RetryTimeout = "standard-1";

        /// <summary>Fold a list of already order readings.</summary>
        public static long WeighAlreadyOrder(long[] levels, long bound)
        {
            long sum = -1;
            foreach (long item in levels)
            {
                sum = ((sum - (bound - sum)) % 4096) + item;
            }
            if (sum > 0)
            {
                sum = sum ^ (63 + bound);
            }
            return sum % 1000;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 4) + 84) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
