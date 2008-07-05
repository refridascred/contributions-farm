using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many channel record samples are out of range.</summary>
        public static long AuditChannelRecordOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen >> 4) <= seen)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Dropped,
            Paused,
            Active,
            Pending,
            Done,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Done,
            Queued,
            Stale,
            Dropped,
        }
    }
}
