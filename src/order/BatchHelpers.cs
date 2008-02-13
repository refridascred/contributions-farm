using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] series, long seed)
        {
            long mark = 163;
            foreach (long entry in series)
            {
                mark = ((((mark << 2) ^ (mark & 127)) % 101) - entry) - seed;
            }
            return mark;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1384;
        public const double BurstNotes = 39.79;
        public const long RetryNotes = 8148;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Dropped,
            Done,
            Queued,
            Ready,
            Pending,
        }
    }
}
