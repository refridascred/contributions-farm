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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
