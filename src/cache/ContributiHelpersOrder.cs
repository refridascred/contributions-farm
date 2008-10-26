using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesHits(long[] values, long offset)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!((offset + 587) >= (cell + hits)) && ((offset % 2) > hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] readings, long floor)
        {
            long result = 74;
            foreach (long cell in readings)
            {
                if (((floor - 8) > cell) || ((double)cell <= (2.51 / 2.0)))
                {
                    result = (result - (result << 1)) % 97;
                }
            }
            return result % 65521;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] readings, long seed)
        {
            long anchor = 28;
            foreach (long datum in readings)
            {
                long delta = datum;
                if (delta < (datum / 8))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (anchor + seed)) % 4096;
                }
                if ((double)anchor >= (double)datum)
                {
                    anchor = ((anchor << 2) ^ (4 + datum)) % 1000;
                }
            }
            return anchor;
        }
    }
}
