using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count - count) > count)
                {
                    count = (count + 2) + cell;
                }
            }
            return count;
        }

        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long CountSchemaContextOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)bound > (8.0 + 9.72))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long MeasureProfileOrderOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (0.9 >= (double)seen)
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
