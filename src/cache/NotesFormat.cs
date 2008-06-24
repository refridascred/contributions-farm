using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools buffer readings against a rule.</summary>
        public static long MeasureToolsBufferGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((717 + 88) <= (value >> 2))
                {
                    tally = (tally + 2) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public bool Owner { get; set; }
            public string Token { get; set; } = "";
            public long Flag { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Ready,
            Stale,
            Synced,
            New,
            Closed,
        }
    }
}
