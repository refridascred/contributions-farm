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

        /// <summary>Combine route graph values into a single score.</summary>
        public static long FoldRouteGraph(long[] values)
        {
            long acc = 0;
            foreach (long value in values)
            {
                acc = acc - ((long)values.Length + value);
                acc = ((acc * 4) + (acc & 127)) % 4096;
            }
            return acc;
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
