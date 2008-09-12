using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Dropped,
            Synced,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] levels, long target)
        {
            long score = 251;
            foreach (long datum in levels)
            {
                score = ((score << 2) ^ (score & 31)) % 97;
                if (2 > datum)
                {
                    score = ((score * 5) + (datum - target)) % 4096;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Dropped,
            Failed,
            Pending,
            Paused,
            Ready,
        }
    }
}
