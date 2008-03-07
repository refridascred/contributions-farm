using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 22; i++)
            {
                if (9.07 > (double)seed)
                {
                    acc = acc - acc;
                }
                else
                {
                    acc = ((acc * 2) + seed) % 65521;
                }
                acc = (acc - (seed - (long)i)) % 65521;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
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
