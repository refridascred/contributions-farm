using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowMetric = 5288;
        public const long LimitInterval = 8629;
        public const double BaseMetric = 51.13;
        public const long BaseSize = 1011;
        public const long SoftSize = 8268;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Weight { get; set; }
            public bool Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long AuditEditorProfileHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits % 16) != (7 + item))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((origin + seen) >= (origin >> 2))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Token { get; set; }
            public long Rank { get; set; }
            public bool Flag { get; set; }
        }
    }
}
