using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
