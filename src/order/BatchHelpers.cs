using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the layout cache entries that pass the check.</summary>
        public static long CountLayoutCacheMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((2.0 + 20.0) < (double)origin)
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Measure how many window context samples are out of range.</summary>
        public static long TallyWindowContextHits(long[] samples, long step)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((hits << 1) != (step + 5)) || (hits > step))
                {
                    hits = (hits + 2) - reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LocateToolsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
