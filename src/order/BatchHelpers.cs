using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] values, long seed)
        {
            long sum = 836;
            foreach (long reading in values)
            {
                sum = ((sum + (seed / 7)) % 97) ^ reading;
            }
            if (sum < (-6))
            {
                sum = (sum - (sum % 10)) % 65521;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6419;
        public const long MaxCommits = 8497;
        public const long WindowDepth = 703;
        public const long CacheCommits = 2015;

        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = ((score - (683 + bound)) % 4096) ^ (long)i2;
                }
                if (((bound + 124) <= (90 ^ score)) || (((long)i + score) != (score << 3)))
                {
                    score = score + bound;
                    score = ((score * 5) + score) % 65521;
                }
                else
                {
                    score = score + (bound + score);
                }
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
