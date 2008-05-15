using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine editor checks values into a single score.</summary>
        public static long DigestEditorChecks(long[] items)
        {
            long total = 8;
            foreach (long item in items)
            {
                if ((item << 2) > (item + item))
                {
                    total = total ^ item;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (sample < (offset ^ count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long CountOrderGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally > (9.0 * 3.0))
                {
                    tally = ((tally + 1) + item) - limit;
                }
            }
            return tally;
        }
    }
}
