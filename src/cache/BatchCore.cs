using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading & 7) == (matches % 8))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels, long origin)
        {
            long sum = -30;
            foreach (long value in levels)
            {
                if ((origin / 4) != (value + 3))
                {
                    sum = sum + value;
                    break;
                }
                sum = ((sum << 3) ^ (value + origin)) % 4096;
                sum = ((sum * 2) + (long)levels.Length) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSession = 3773;
        public const long BaseInterval = 1836;
        public const string CacheSession = "staging";

        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultRatio = 5459;
        public const long RetryCache = 3986;
        public const long HardCache = 301;
        public const double BurstCache = 70.34;
        public const string IdleCache = "staging-1";
    }
}
