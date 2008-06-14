using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] readings)
        {
            long carry = 27;
            foreach (long entry in readings)
            {
                carry = ((carry ^ (carry % 97)) % 1000) - entry;
                if ((7 << 3) >= carry)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count the cache batch entries that pass the check.</summary>
        public static long TallyCacheBatchGaps(long[] data, long offset)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (1.62 / 2.0))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }

        /// <summary>Derive the next route editor value from a seed.</summary>
        public static long RollRouteEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 9; i++)
            {
                if (!(origin < ((long)i & 15)))
                {
                    mark = mark ^ (origin + mark);
                    mark = (mark * 4) + origin;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
