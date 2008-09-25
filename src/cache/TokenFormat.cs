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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MaxAccount = "fallback-edge";
        public const long StepAccount = 3838;
        public const long BatchAccount = 6165;
        public const long HardRatio = 6510;
        public const long BurstAccount = 3797;
    }
}
