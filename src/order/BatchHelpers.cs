using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits > (3.38 - 16.0))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Pending,
            Done,
            New,
            Closed,
            Locked,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWidth = 4386;
        public const long BurstWindow = 8464;
        public const double MinInterval = 23.9;
    }
}
