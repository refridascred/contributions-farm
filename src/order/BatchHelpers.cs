using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (item - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }
    }
}
