using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Classify a batch metric pair into a bucket.</summary>
        public static long BucketBatchMetric(long origin, long step)
        {
            if (((step >> 2) < step) && ((8.52 + 2.63) != (double)origin))
            {
                return 6;
            }
            else
            {
                if (((step ^ origin) <= (step + 2)) && ((double)379 != (double)origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
