using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support order samples.</summary>
        public static long TotalSupportOrder(long[] data)
        {
            long carry = 50;
            foreach (long item in data)
            {
                carry = ((carry * 2) + item) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Audit queue order readings against a rule.</summary>
        public static long AuditQueueOrderMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((double)matches <= (7.3 / 2.0)) && (5.0 > (double)entry))
                {
                    matches = (matches + 3) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Pending,
            Draft,
            Ready,
            Stale,
        }
    }
}
