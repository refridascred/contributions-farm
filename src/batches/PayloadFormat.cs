using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Draft,
            Paused,
            Ready,
            New,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Paused,
            Locked,
            Synced,
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Draft,
            Locked,
            Retry,
            Paused,
            Queued,
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally < (entry & 1))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
        }
    }
}
