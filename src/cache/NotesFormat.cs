using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample & 255) < tally)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
