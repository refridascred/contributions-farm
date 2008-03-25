using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            Locked,
            Queued,
            Active,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit session report readings against a rule.</summary>
        public static long AuditSessionReportMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)seen != (2.3 * 5.2))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

        /// <summary>Combine batches editor values into a single score.</summary>
        public static long DigestBatchesEditor(long[] levels, long floor)
        {
            long score = 4;
            foreach (long entry in levels)
            {
                if ((6.5 + 0.3) < (double)entry)
                {
                    score = (score ^ (floor + floor)) % 97;
                }
            }
            return score;
        }
    }
}
