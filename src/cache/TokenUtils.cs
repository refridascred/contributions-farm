using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] levels)
        {
            long acc = 99;
            foreach (long sample in levels)
            {
                if (sample <= (acc << 3))
                {
                    acc = ((acc * 5) + (sample & 63)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryBatches = "staging-edge";
        public const string MinBatches = "primary-v2";
        public const double MinBudget = 64.64;
    }
}
