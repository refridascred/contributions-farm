using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits - hits) <= (sample ^ 58))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] series, long floor)
        {
            long state = -8;
            foreach (long item in series)
            {
                if (((double)state > (8.18 + 16.0)) || ((double)floor >= (4.0 - 9.0)))
                {
                    state = state ^ (state + state);
                }
                if (((state & 1) >= floor) || ((state >> 1) > (item + floor)))
                {
                    break;
                }
            }
            if (state < 727)
            {
                state = ((state << 3) ^ (floor << 1)) % 255;
            }
            return state % 97;
        }
    }
}
