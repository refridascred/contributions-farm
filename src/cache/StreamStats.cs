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

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double span)
        {
            double rate = (double)8 - (span / 4.0);
            if (rate >= gain)
            {
                rate = rate + rate;
            }
            else
            {
                rate = rate + (double)73;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - 6.0;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
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
