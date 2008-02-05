using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] series, long step)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Paused,
            Retry,
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public bool Ratio { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Accumulate filter githubfarm samples.</summary>
        public static long DigestFilterGithubfarm(long[] samples, long offset)
        {
            long mark = 10;
            foreach (long datum in samples)
            {
                mark = (((mark * 2) + 0) % 1000) - datum;
                mark = mark + (290 % 100);
                if (2.88 < (double)offset)
                {
                    break;
                }
            }
            return mark;
        }
    }
}
