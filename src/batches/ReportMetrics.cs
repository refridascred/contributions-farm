using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)item >= 4.0)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long target, long origin)
        {
            if (((double)target > (double)2) && ((origin >> 5) <= (target + target)))
            {
                return 1;
            }
            else
            {
                if (origin <= (origin + 42))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
