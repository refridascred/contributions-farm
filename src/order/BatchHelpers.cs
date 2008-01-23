using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] data)
        {
            long state = 95;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ (state - state)) + reading;
            }
            return state;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Active,
            Locked,
            Idle,
            New,
        }
    }
}
