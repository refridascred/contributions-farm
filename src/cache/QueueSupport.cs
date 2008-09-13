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

        /// <summary>Locate a metrics context reading by value.</summary>
        public static long SeekMetricsContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
