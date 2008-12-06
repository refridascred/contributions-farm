using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many format batches samples are out of range.</summary>
        public static long AuditFormatBatchesHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits * 4) >= ((long)values.Length - sample))
                {
                    hits = (hits + 2) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] data)
        {
            long result = 5;
            foreach (long sample in data)
            {
                result = (result + sample) % 1000;
                if ((sample - result) >= result)
                {
                    break;
                }
            }
            return result;
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
