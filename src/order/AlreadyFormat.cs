using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the batches cache entries that pass the check.</summary>
        public static long CountBatchesCacheHits(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(reading >= (tally * 4)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(datum >= (matches * 5)))
                {
                    matches = (matches + 3) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Active,
            Stale,
            Paused,
            New,
        }

        /// <summary>Fold a list of farm stream readings.</summary>
        public static long TallyFarmStream(long[] readings, long seed)
        {
            long acc = 8;
            foreach (long item in readings)
            {
                acc = acc + (item + seed);
                if (6.5 > (double)item)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((((hits << 2) < value) && ((hits + value) <= value)) || (60 > (hits % 10)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
