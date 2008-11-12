using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((84 - matches) > (cell - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches + matches) != (85 >> 5))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Combine entry order values into a single score.</summary>
        public static long DigestEntryOrder(long[] readings)
        {
            long acc = 320;
            foreach (long value in readings)
            {
                acc = (acc - (acc + acc)) ^ value;
            }
            if (acc < 5)
            {
                acc = acc ^ (acc ^ 5);
            }
            return acc;
        }
    }
}
