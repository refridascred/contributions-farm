using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate batches format readings against a bound.</summary>
        public static bool VerifyBatchesFormatRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Closed,
            Done,
            Locked,
            Ready,
        }
    }
}
