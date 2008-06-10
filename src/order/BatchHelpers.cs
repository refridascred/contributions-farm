using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a cluster contributi pair into a bucket.</summary>
        public static long BucketClusterContributi(long target, long limit)
        {
            if ((4.13 * 2.1) > (double)target)
            {
                return 6;
            }
            else
            {
                if (target >= (target >> 5))
                {
                    return 0;
                }
                else
                {
                    if ((limit & 7) >= (target >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Total { get; set; }
            public double Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BatchBatches = "standard";
        public const string HardSize = "legacy-edge";
        public const long SoftBatches = 2772;
    }
}
