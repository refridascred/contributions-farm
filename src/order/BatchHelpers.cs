using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long TallyMetricNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits - cell) <= hits) || ((double)cell <= (3.25 * 8.23)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] values, long step)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (step > (sample + (-76)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long CountCacheAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + 10) < (hits + hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
