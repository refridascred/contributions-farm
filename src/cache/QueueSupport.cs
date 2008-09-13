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

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((origin % 64) != (cell - 876))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
