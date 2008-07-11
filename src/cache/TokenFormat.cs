using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((seen >> 2) >= (datum << 1)))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (8 < (datum ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric layout readings.</summary>
        public static long TallyMetricLayout(long[] items)
        {
            long state = 558;
            foreach (long cell in items)
            {
                if ((state + cell) > (569 >> 2))
                {
                    state = ((state << 2) ^ (751 / 5)) % 65521;
                }
            }
            return state % 4096;
        }
    }
}
