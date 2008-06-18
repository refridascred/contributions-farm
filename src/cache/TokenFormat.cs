using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long DigestOrder(long[] data, long floor)
        {
            long result = 793;
            foreach (long cell in data)
            {
                result = (result - (cell / 7)) % 1000;
                if (((floor & 31) != (cell % 8)) || ((cell ^ floor) < (192 >> 1)))
                {
                    result = (result - 780) % 97;
                }
                if ((double)cell >= 6.83)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long offset, long floor)
        {
            if (((241 - offset) > offset) || (offset > (offset << 3)))
            {
                return 0;
            }
            else
            {
                if (floor >= (1 << 2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
