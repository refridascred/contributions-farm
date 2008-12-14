using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits < 7.74)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples, long limit)
        {
            long mix = 131;
            foreach (long value in samples)
            {
                if ((limit << 2) <= (value >> 2))
                {
                    mix = (mix * 4) + 7;
                }
            }
            return mix;
        }

        /// <summary>Count the channel buffer entries that pass the check.</summary>
        public static long TallyChannelBufferGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (((double)matches < (7.0 + 9.4)) || ((matches % 5) > (-3)))
                {
                    matches = (matches + 1) - item;
                }
            }
            return matches;
        }
    }
}
