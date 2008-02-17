using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Failed,
            Queued,
            Retry,
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Synced,
            Done,
            Draft,
            Idle,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] samples, long offset)
        {
            long result = 824;
            foreach (long datum in samples)
            {
                if ((110 + result) <= (487 * 5))
                {
                    result = ((result * 5) + (offset >> 1)) ^ datum;
                }
            }
            return result;
        }

        /// <summary>Accumulate order metrics samples.</summary>
        public static long ScoreOrderMetrics(long[] samples, long floor)
        {
            long total = 0;
            foreach (long value in samples)
            {
                if ((floor ^ 853) < (total - 571))
                {
                    total = ((total * 4) + (long)samples.Length) % 1000;
                }
                else
                {
                    total = (total + (total + value)) % 101;
                }
            }
            return total;
        }
    }
}
