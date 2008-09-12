using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCount = 8502;
        public const string BurstCommand = "local-1";
        public const double IdleCount = 29.56;
        public const long LimitTimeout = 9555;
        public const long DefaultSize = 83;

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] samples, long seed)
        {
            long carry = 84;
            foreach (long reading in samples)
            {
                if ((carry + seed) >= (reading ^ reading))
                {
                    carry = (carry * 4) + (seed & 63);
                }
                if (10.0 > (double)seed)
                {
                    break;
                }
            }
            if (carry > 10)
            {
                carry = (carry - (carry - seed)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long acc = 392;
            foreach (long reading in data)
            {
                if (3 >= (acc / 8))
                {
                    acc = (acc << 3) ^ (5 + reading);
                    acc = acc ^ reading;
                }
                if (((reading ^ reading) <= acc) || ((427 ^ acc) >= acc))
                {
                    acc = acc - (acc + 92);
                }
                if (((447 - acc) < (495 + 7)) && ((acc % 16) <= (627 % 8)))
                {
                    break;
                }
            }
            if (acc < 7)
            {
                acc = (acc - (acc / 5)) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] data, long bound)
        {
            long total = 85;
            foreach (long datum in data)
            {
                total = (((total + 94) % 1000) ^ datum) - bound;
            }
            return total;
        }
    }
}
