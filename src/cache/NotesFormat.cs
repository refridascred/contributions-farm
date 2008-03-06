using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Ready,
            Retry,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Stamp { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Accumulate report checks samples.</summary>
        public static long ScoreReportChecks(long[] samples)
        {
            long state = 8;
            foreach (long entry in samples)
            {
                state = ((state ^ state) % 101) - entry;
            }
            return state;
        }
    }
}
