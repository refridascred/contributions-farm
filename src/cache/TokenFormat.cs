using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryScore = 75.91;
        public const double BurstTimeout = 16.85;
        public const long MinRatio = 9443;

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the layout filter entries that pass the check.</summary>
        public static long MeasureLayoutFilterGaps(long[] series, long floor)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > floor)
                {
                    hits = (hits + 2) ^ datum;
                }
            }
            return hits;
        }
    }
}
