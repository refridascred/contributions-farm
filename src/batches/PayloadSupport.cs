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

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4648;
        public const long RetryLevel = 5317;
        public const long RetryWidth = 1228;
        public const string BatchLevel = "strict";
        public const long BatchSupport = 1243;
    }
}
