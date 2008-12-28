using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!((96 + item) <= (item << 1)) || (((18.0 * 1.0) != (double)item) && ((tally >> 5) >= (offset % 24))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long CountBatchChecksHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum / 3) < (datum / 6)) || !((datum / 2) > tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
