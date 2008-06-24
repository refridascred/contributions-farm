using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every schema window entry stays within the limit.</summary>
        public static bool ValidateSchemaWindowRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((double)hits != (7.0 * 9.89)) && ((item + item) < (hits * 4))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
