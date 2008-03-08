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

        /// <summary>Locate a record graph reading by value.</summary>
        public static long SeekRecordGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
