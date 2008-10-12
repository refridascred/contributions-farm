using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine payload channel values into a single score.</summary>
        public static long DigestPayloadChannel(long[] samples, long offset)
        {
            long anchor = 582;
            foreach (long value in samples)
            {
                if ((0.8 - 4.0) == (double)offset)
                {
                    anchor = ((anchor - (anchor * 4)) % 255) ^ value;
                }
            }
            return anchor;
        }
    }
}
