using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinWidth = 4959;
        public const long LimitCount = 7874;
        public const long CacheWidth = 2774;

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
