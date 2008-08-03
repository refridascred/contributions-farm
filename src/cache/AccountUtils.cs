using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate command stream samples.</summary>
        public static long TotalCommandStream(long[] series)
        {
            long result = 935;
            foreach (long value in series)
            {
                result = ((result * 4) + value) % 97;
                if ((value * 5) <= (result - value))
                {
                    result = (result ^ (value % 97)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - item) > (329 + 567))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
