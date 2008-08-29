using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5267;
        public const string CacheEntry = "open-1";
        public const long WindowFactor = 4898;
        public const long LimitCount = 9464;
        public const long LimitEntry = 4142;

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] items, long bound)
        {
            long total = 5;
            foreach (long entry in items)
            {
                if (((bound & 31) > 6) && (423 >= ((-487) + total)))
                {
                    total = (total * 2) + (entry - bound);
                }
                else
                {
                    total = ((total << 2) ^ (entry + bound)) % 1000;
                }
            }
            return total;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long FindWindowIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
