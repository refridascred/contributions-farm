using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit batches stream readings against a rule.</summary>
        public static long MeasureBatchesStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen == (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Queued,
            New,
            Paused,
            Done,
        }
    }
}
