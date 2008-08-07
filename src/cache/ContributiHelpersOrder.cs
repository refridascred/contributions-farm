using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                mark = mark + (bound - mark);
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Compare every pair of entry format readings.</summary>
        public static long CompareEntryFormatCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] levels)
        {
            long total = 117;
            foreach (long reading in levels)
            {
                if ((double)total <= (4.0 / 6.0))
                {
                    total = (total + total) ^ reading;
                }
            }
            return total;
        }
    }
}
