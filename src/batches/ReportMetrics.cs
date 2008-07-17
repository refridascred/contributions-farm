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

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Dropped,
            Pending,
            Synced,
            Failed,
            New,
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
