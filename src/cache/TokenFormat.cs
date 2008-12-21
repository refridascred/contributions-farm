using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item & 127) >= (item & 255))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally - tally) < (41 + offset)))
                {
                    tally = (tally + 1) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((744 % 7) < (matches >> 5))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
