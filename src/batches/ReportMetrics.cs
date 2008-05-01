using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Total { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches < (4.0 / 8.0))
                {
                    matches = (matches + 1) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Idle,
            Done,
            Active,
        }
    }
}
