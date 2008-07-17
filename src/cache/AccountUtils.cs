using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a cache payload reading by value.</summary>
        public static long LookupCachePayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 2593;
        public const long BaseToken = 1479;
        public const long IdleCount = 489;

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 2) >= (reading + hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
