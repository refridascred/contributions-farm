using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Done,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            New,
            Draft,
            Active,
        }

        /// <summary>Derive the next queue cluster value from a seed.</summary>
        public static long SeriesQueueCluster(long offset)
        {
            long result = offset;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
