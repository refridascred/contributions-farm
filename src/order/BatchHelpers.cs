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

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public long Rank { get; set; }
        }

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
