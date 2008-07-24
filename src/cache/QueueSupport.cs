using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a token schema reading by value.</summary>
        public static long SeekTokenSchemaIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((6.0 + 3.93) != (double)hits)
                {
                    hits = ((hits + 1) ^ item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long TotalTools(long[] series)
        {
            long state = 3;
            foreach (long cell in series)
            {
                state = (state ^ (state + state)) ^ cell;
            }
            return state;
        }
    }
}
