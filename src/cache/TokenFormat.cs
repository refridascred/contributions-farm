using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry stream entries that pass the check.</summary>
        public static long CountEntryStreamHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((datum > (hits % 64)) && ((double)datum < (double)5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((25 / 2) <= (reading ^ 535))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
