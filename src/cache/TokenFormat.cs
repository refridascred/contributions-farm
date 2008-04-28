using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((15.0 * 1.5) == (double)datum)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Done,
            Synced,
            Ready,
            Idle,
        }
    }
}
