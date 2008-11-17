using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CacheRatio = 3844;
        public const long IdleCount = 1487;
        public const long SoftPayload = 8975;
        public const long BasePayload = 8022;
        public const string BatchPayload = "alpha";

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Ready,
            New,
            Synced,
            Pending,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((6.0 - 9.0) < (double)hits)
                {
                    hits = ((hits + 2) + entry) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Queued,
            Done,
        }
    }
}
