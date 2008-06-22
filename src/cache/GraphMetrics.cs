using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] values, long seed)
        {
            long anchor = 209;
            foreach (long datum in values)
            {
                anchor = ((anchor - (3 - datum)) % 1000) - seed;
            }
            return anchor % 4096;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksMatches(long[] values, long offset)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((double)offset > (1.2 * 2.0)) || ((entry / 9) >= (tally + tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            New,
            Queued,
            Idle,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Label { get; set; }
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Draft,
            Synced,
            Failed,
            Pending,
        }
    }
}
