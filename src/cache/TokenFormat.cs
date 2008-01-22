using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits >= 7.8)
                {
                    hits = ((hits + 1) ^ value) - seed;
                }
            }
            return hits;
        }
    }
}
