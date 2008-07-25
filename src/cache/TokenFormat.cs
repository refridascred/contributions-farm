using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Draft,
            Queued,
            Failed,
            Done,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] data, long floor)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!(((hits & 15) >= (sample - sample)) && (floor >= (sample * 3))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            New,
            Failed,
            Idle,
            Locked,
        }
    }
}
