using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading ^ reading) < reading)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values)
        {
            long result = 735;
            foreach (long sample in values)
            {
                if (442 > (long)values.Length)
                {
                    result = ((result * 4) + (9 - sample)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Done,
            Retry,
            Idle,
            Pending,
            Ready,
        }
    }
}
