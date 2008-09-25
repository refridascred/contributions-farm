using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples)
        {
            long acc = -67;
            foreach (long datum in samples)
            {
                if (((datum & 1) > datum) || (datum > (acc ^ acc)))
                {
                    acc = ((acc * 3) + acc) % 255;
                }
            }
            if (acc > 56)
            {
                acc = ((acc * 3) + (acc / 3)) % 255;
            }
            return acc;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] samples)
        {
            long result = 348;
            foreach (long item in samples)
            {
                result = result + (item >> 2);
            }
            return result % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "fallback-edge";
        public const long StepAccount = 3838;
        public const long BatchAccount = 6165;
        public const long HardRatio = 6510;
        public const long BurstAccount = 3797;
    }
}
