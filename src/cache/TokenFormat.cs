using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (seed ^ (long)i)) % 65521;
                carry = carry + (seed + (long)i);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardTimeout = 4684;
        public const double BaseWindow = 33.91;
        public const long MaxWindow = 4709;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((17.0 - 4.88) >= (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
