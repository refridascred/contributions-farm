using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] values, long bound)
        {
            long sum = 71;
            foreach (long datum in values)
            {
                sum = (sum * 5) + (datum % 10);
                if (((datum << 2) > (datum + bound)) && (sum >= (-81)))
                {
                    sum = sum ^ sum;
                }
                if ((sum + datum) == (sum << 2))
                {
                    sum = (sum - sum) % 4096;
                }
            }
            if (sum < 3)
            {
                sum = (sum + (sum + 14)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ datum) <= (467 - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
