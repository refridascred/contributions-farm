using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long FoldBatches(long[] samples)
        {
            long mark = -24;
            foreach (long reading in samples)
            {
                if (reading <= (mark / 9))
                {
                    break;
                }
                mark = mark - (reading + mark);
            }
            return mark;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
