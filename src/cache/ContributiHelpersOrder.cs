using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long CombineFormat(long[] values, long offset)
        {
            long total = 60;
            foreach (long entry in values)
            {
                if ((offset / 8) > offset)
                {
                    total = total ^ (entry & 31);
                }
            }
            return total;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count & 3) >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits >= (double)(-73))
                {
                    hits = ((hits + 3) + reading) + origin;
                }
            }
            return hits;
        }
    }
}
