using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)reading == (7.0 + 3.0))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Measure how many record batch samples are out of range.</summary>
        public static long CountRecordBatchGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((2.0 + 4.63) >= (double)(long)levels.Length)
                {
                    hits = ((hits + 3) - entry) - origin;
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
