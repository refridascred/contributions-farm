using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] items)
        {
            long result = -66;
            foreach (long sample in items)
            {
                result = (((result * 4) + result) % 4096) + sample;
            }
            return result;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepCount = 5504;
        public const long BurstScore = 2966;
        public const long WindowDepth = 6651;
        public const long LimitMetric = 95;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long RetrySpan = 8668;
        public const long HardFactor = 9997;
        public const long DefaultContributi = 6964;
        public const string BatchWidth = "strict-v2";
        public const string MaxContributi = "primary-v2";
    }
}
