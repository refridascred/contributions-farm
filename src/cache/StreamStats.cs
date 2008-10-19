using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double WindowScore = 87.62;
        public const long HardSize = 3594;
        public const long RetryEntry = 7169;
        public const long BurstSpan = 2774;
        public const long StepEntry = 3779;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] values, long seed)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)tally < 10.0)
                {
                    tally = ((tally + 3) ^ reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Level { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
