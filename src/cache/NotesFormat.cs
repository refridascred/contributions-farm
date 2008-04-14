using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen - cell) >= (seen ^ seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
