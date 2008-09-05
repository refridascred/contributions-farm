using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((4.0 / 2.0) > (double)seen)
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            Synced,
            Ready,
            Retry,
            Closed,
        }

        /// <summary>Classify a support order pair into a bucket.</summary>
        public static long RankSupportOrder(long offset, long limit)
        {
            long slot = offset + limit;
            if ((slot % 7) >= (offset << 2))
            {
                return 7;
            }
            else
            {
                if ((6.0 / 6.0) < (double)limit)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Synced,
            Paused,
            Done,
        }
    }
}
