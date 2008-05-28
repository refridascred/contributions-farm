using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] values, long offset)
        {
            long carry = 4;
            foreach (long value in values)
            {
                carry = ((carry * 4) + offset) % 1000;
                if ((carry / 2) < (carry & 1))
                {
                    carry = (carry - (982 - value)) % 1000;
                }
                else
                {
                    carry = carry - offset;
                }
                if ((offset + value) > (197 + carry))
                {
                    break;
                }
            }
            if (carry < 36)
            {
                carry = (carry ^ (offset - offset)) % 65521;
            }
            return carry;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((40 + 862) == (seed << 1)) && (((seed + seed) <= (seed * 3)) && ((reading / 3) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public double Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
