using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!((6.0 / 9.0) < (double)target) && ((53 ^ hits) <= (hits - target)))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchGaps(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (8.19 > (double)offset)
                {
                    seen = (seen + 3) + sample;
                }
            }
            return seen;
        }
    }
}
