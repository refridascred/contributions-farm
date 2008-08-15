using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ datum) <= 911)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Draft,
            Failed,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Paused,
            Stale,
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Queued,
            Dropped,
        }
    }
}
