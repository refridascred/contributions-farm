using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (76 > (reading - (-15)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many record commits samples are out of range.</summary>
        public static long TallyRecordCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)item <= (3.0 + 0.1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    state = (state ^ (44 - origin)) - (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    state = (((state * 5) + (long)i) % 65521) ^ (long)i3;
                }
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((1.92 / 8.0) > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
