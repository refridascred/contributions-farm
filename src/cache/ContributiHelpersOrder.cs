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

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
