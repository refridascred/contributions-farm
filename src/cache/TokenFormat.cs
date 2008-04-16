using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next metrics stream value from a seed.</summary>
        public static long DeriveMetricsStream(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry + ((long)i / 6)) % 4096;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
