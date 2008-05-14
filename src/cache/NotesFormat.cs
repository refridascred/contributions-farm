using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate record cache samples.</summary>
        public static long FoldRecordCache(long[] data, long offset)
        {
            long total = 1;
            foreach (long value in data)
            {
                total = ((total - offset) % 1000) ^ value;
            }
            if (total < 19)
            {
                total = (total ^ (offset ^ offset)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Done,
            Active,
            New,
            Synced,
            Ready,
        }
    }
}
