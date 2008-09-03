using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Done,
            Active,
            Idle,
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits + value) == (value & 63))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Locked,
            Stale,
            Dropped,
        }
    }
}
