using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double HardBatches = 88.52;
        public const long BaseBatches = 8780;
        public const long IdleLevel = 1563;
        public const long BatchBatches = 9020;
        public const long BatchTimeout = 628;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Queued,
            Pending,
            Closed,
            Idle,
            Locked,
        }

        /// <summary>Audit cluster checks readings against a rule.</summary>
        public static long MeasureClusterChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((38 + seen) >= (seen * 4))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a support editor sample.</summary>
        public static long SeekSupportEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
