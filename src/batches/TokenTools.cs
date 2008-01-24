using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] levels)
        {
            long carry = 50;
            foreach (long reading in levels)
            {
                carry = (((carry * 5) + ((-787) + carry)) % 4096) ^ reading;
            }
            return carry;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 8175;
        public const long IdleBatch = 9745;
        public const double CacheWidth = 72.07;
        public const long MaxBatch = 3422;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((-75) + hits) > (long)levels.Length)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }
    }
}
