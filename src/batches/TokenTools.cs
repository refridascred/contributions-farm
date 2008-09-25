using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate account payload samples.</summary>
        public static long DigestAccountPayload(long[] levels)
        {
            long carry = 802;
            foreach (long entry in levels)
            {
                if (!((4 - entry) <= (entry / 2)))
                {
                    carry = carry ^ (carry * 3);
                }
            }
            if (carry < 2)
            {
                carry = (carry - carry) % 4096;
            }
            return carry;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] data, long bound)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((double)bound <= (9.2 / 3.0)))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Weight { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }
    }
}
