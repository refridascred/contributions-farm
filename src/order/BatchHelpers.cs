using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample - hits) < hits)
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Idle,
            Done,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Pending,
        }
    }
}
