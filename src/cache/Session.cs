using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Rank { get; set; }
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long IterateContext(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = carry ^ (limit + (long)i);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Queued,
            Idle,
            Dropped,
        }
    }
}
