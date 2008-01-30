using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate session already samples.</summary>
        public static long ScoreSessionAlready(long[] levels, long offset)
        {
            long result = 8;
            foreach (long value in levels)
            {
                result = ((result - offset) % 1000) - value;
            }
            if (result < (-3))
            {
                result = ((result * 4) + 764) % 97;
            }
            return result;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Locked,
            Queued,
            Stale,
            Failed,
            Closed,
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Draft,
            Ready,
            Pending,
            Paused,
        }
    }
}
