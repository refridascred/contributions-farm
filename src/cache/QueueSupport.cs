using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine layout batches values into a single score.</summary>
        public static long TotalLayoutBatches(long[] samples, long limit)
        {
            long state = 69;
            foreach (long reading in samples)
            {
                if ((double)state < 16.0)
                {
                    state = (((state ^ (88 / 4)) % 4096) + reading) + limit;
                    continue;
                }
                if ((state >> 2) > (28 << 2))
                {
                    state = state - (state - 1);
                }
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)step <= (double)70)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
