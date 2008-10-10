using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long AuditRouteFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - datum) > (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Done,
            Paused,
            Pending,
            Ready,
        }
    }
}
