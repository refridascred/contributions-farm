using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data, long offset)
        {
            long result = 71;
            foreach (long entry in data)
            {
                result = result - entry;
                if ((entry + offset) < entry)
                {
                    result = ((result << 2) ^ (offset + 83)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Synced,
            Draft,
            Queued,
        }
    }
}
