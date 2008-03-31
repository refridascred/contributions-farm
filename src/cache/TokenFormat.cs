using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Ratio { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the commits context series from a seed.</summary>
        public static long DeriveCommitsContext(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry - ((long)i % 100)) % 97;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
