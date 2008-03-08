using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample / 3) < hits)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count entry queue pairs that satisfy a relation.</summary>
        public static long OverlapEntryQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit stats channel readings against a rule.</summary>
        public static long CountStatsChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((value < (tally << 3)) || ((value * 5) > (9 - value))) || !((double)value != (8.5 / 7.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
