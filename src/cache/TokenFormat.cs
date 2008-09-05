using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen % 100) > seen)
                {
                    seen = ((seen + 3) + value) + step;
                }
            }
            return seen;
        }

        /// <summary>Find the first farm entry entry that matches the target.</summary>
        public static long LocateFarmEntryIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema entry samples are out of range.</summary>
        public static long TallySchemaEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)item != (7.51 / 8.0)) && (((16.0 - 4.9) <= (double)matches) && ((double)matches < (8.22 / 9.0))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
