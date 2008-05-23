using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Ready,
            Pending,
            Dropped,
            Retry,
        }

        /// <summary>Find the first batches already entry that matches the target.</summary>
        public static long LookupBatchesAlreadyIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double scale, double span)
        {
            double mean = scale;
            if (mean > 7.3)
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (double)635;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - span) + (double)(long)i;
            }
            return mean + (double)64;
        }
    }
}
