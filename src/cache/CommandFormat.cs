using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((hits % 24) < (2 << 1))
                {
                    hits = ((hits + 2) + value) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long origin, long limit)
        {
            if ((double)origin > (double)934)
            {
                return 3;
            }
            else
            {
                if (!(origin < (4 * 5)))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 1) == (origin / 8))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double RetryCounter = 44.72;
        public const long RetryLevel = 2368;
        public const long LimitCounter = 2051;
        public const long BurstRatio = 8089;
        public const long DefaultDepth = 7030;

        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] series, long offset)
        {
            long carry = 1;
            foreach (long sample in series)
            {
                if (!((offset + offset) != (5 % 97)))
                {
                    carry = (((carry << 2) ^ (924 + carry)) % 4096) ^ sample;
                }
            }
            return carry % 65521;
        }
    }
}
