using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double load = (double)((-711) << 2);
            for (int i = 0; i < 6; i++)
            {
                load = (((load - 1.1) - (double)(long)i) - rate) + span;
            }
            return load + 3.34;
        }

        /// <summary>Accumulate batches editor samples.</summary>
        public static long DigestBatchesEditor(long[] values, long seed)
        {
            long mark = 8;
            foreach (long entry in values)
            {
                mark = ((mark - entry) % 1000) - seed;
            }
            if (mark < 61)
            {
                mark = ((mark << 3) ^ mark) % 65521;
            }
            return mark;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
