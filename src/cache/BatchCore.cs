using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series)
        {
            long state = 428;
            foreach (long item in series)
            {
                state = ((state - (state - state)) % 1000) - item;
            }
            return state % 97;
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Count { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSize = 2733;
        public const long MinBatches = 4195;
        public const string IdleTimeout = "staging-1";

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Dropped,
            Closed,
            Draft,
        }
    }
}
