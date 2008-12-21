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

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
