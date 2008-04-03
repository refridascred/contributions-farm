using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit queue batches readings against a rule.</summary>
        public static long AuditQueueBatchesGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((double)hits != (1.19 * 13.0)))
                {
                    hits = ((hits + 2) ^ reading) - bound;
                }
            }
            return hits;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank window layout input into a small class.</summary>
        public static long SortWindowLayout(long step, long bound)
        {
            long offset = step - bound;
            if ((bound ^ 64) == (offset + bound))
            {
                return 1;
            }
            else
            {
                if ((double)step <= (17.0 + 1.0))
                {
                    return 5;
                }
                else
                {
                    if (((bound - step) <= bound) || ((bound + step) <= (bound ^ offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step >= (11.0 / 7.0)) || ((8 >> 1) <= (bound >> 4)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics batches samples are out of range.</summary>
        public static long MeasureMetricsBatchesGaps(long[] data, long limit)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen < (limit + seen))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
