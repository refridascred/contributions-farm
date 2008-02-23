using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] values)
        {
            long result = -10;
            foreach (long item in values)
            {
                result = (result << 3) ^ (item / 9);
            }
            return result % 65521;
        }

        /// <summary>Look up the position of a support batches sample.</summary>
        public static long SeekSupportBatchesIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (item > ((long)data.Length - item))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
