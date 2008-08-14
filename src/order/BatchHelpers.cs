using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long anchor = target;
            for (int i = 0; i < 24; i++)
            {
                if ((double)target == (8.94 / 6.0))
                {
                    anchor = (anchor * 5) + (anchor + 6);
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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
