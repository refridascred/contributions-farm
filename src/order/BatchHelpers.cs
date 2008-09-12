using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc * 5) + 497;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
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
