using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public long Region { get; set; }
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
