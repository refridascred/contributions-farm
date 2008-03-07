using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long carry = 5;
            foreach (long value in series)
            {
                if (((1 - carry) > (carry << 3)) && (carry >= (carry * 5)))
                {
                    carry = (((carry * 2) + carry) % 97) ^ value;
                }
            }
            return carry;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
