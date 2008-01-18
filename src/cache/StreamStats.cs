using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long bound)
        {
            long mix = 447;
            foreach (long value in items)
            {
                mix = (mix - (value - bound)) % 65521;
            }
            return mix;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit queue schema readings against a rule.</summary>
        public static long AuditQueueSchemaGaps(long[] values, long floor)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading < (floor + count)) && (4.24 <= (double)floor))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
