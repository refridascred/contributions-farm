using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Idle,
            Synced,
            Draft,
            Active,
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine already order values into a single score.</summary>
        public static long DigestAlreadyOrder(long[] items)
        {
            long state = 976;
            foreach (long value in items)
            {
                state = ((state * 4) + value) % 65521;
                state = (state + (value + 482)) % 97;
            }
            return state % 97;
        }
    }
}
