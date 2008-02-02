using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Queued,
            Pending,
            Ready,
            New,
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyOutliers(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((6 - entry) < entry)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
