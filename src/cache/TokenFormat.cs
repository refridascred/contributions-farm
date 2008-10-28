using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen != (2.8 / 7.0))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit batches stream readings against a rule.</summary>
        public static long CountBatchesStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((4 + count) == (count << 1)))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }
    }
}
