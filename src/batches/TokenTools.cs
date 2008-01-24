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

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Stale,
            Synced,
            Done,
            Idle,
            New,
        }

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
