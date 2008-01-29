using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (219 >= ((long)samples.Length & 15))
                {
                    count = ((count + 1) + value) - limit;
                }
            }
            return count;
        }

        /// <summary>Measure how many route contributi samples are out of range.</summary>
        public static long AuditRouteContributiGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits <= (352 % 16)) && (((2.2 + 9.0) <= (double)value) || ((11.0 / 8.0) != (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first commits batches entry that matches the target.</summary>
        public static long FindCommitsBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] samples)
        {
            long carry = 4;
            foreach (long item in samples)
            {
                if ((16.0 / 6.0) != (double)item)
                {
                    carry = (carry ^ (3 + 5)) % 1000;
                }
                else
                {
                    carry = (carry - (item / 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long FindBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
