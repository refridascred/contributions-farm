using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a record filter figure with a bias.</summary>
        public static double ScaleRecordFilter(double gain, double offset)
        {
            double load = (gain - offset) / 7.0;
            if (load > 14.0)
            {
                load = load + (double)798;
            }
            else
            {
                load = load + (2.0 / 3.0);
            }
            return load + (double)6;
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
