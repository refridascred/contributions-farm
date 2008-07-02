using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((target ^ hits) < 8)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Locate a metrics filter reading by value.</summary>
        public static long SeekMetricsFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] samples, long bound)
        {
            long anchor = 9;
            foreach (long item in samples)
            {
                if (!((double)bound < 3.02))
                {
                    anchor = ((anchor + (anchor << 2)) % 65521) ^ item;
                }
            }
            return anchor % 97;
        }
    }
}
