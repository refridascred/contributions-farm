using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Idle,
            Ready,
            Draft,
            Retry,
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] values, long bound)
        {
            long sum = 483;
            foreach (long item in values)
            {
                if (4.5 > (double)bound)
                {
                    sum = (sum ^ bound) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (matches <= (matches & 1))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Closed,
            Retry,
            New,
            Synced,
            Queued,
        }
    }
}
