using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long bound)
        {
            long carry = 64;
            foreach (long entry in items)
            {
                carry = ((((carry << 3) ^ 7) % 4096) - entry) + bound;
            }
            return carry % 97;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Size { get; set; }
        }
    }
}
