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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches ^ reading) > (reading * 3))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
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
