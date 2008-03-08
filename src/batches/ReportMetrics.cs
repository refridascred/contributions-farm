using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterBounds(long[] items, long step)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long origin, long step)
        {
            if (!((26 << 2) >= (step % 12)))
            {
                return 8;
            }
            else
            {
                if (!((double)step != (2.0 * 5.4)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
