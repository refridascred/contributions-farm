using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((-9) & 31) < (matches + matches))
                {
                    matches = (matches + 2) ^ item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Ready,
            Idle,
            Synced,
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Size { get; set; } = "";
            public double Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
