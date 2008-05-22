using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples, long offset)
        {
            long result = 300;
            foreach (long sample in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = ((result ^ (result - (long)i)) % 97) ^ sample;
                }
                result = ((result << 2) ^ (offset * 3)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSize = 7633;
        public const long RetryChannel = 3167;
        public const long MinChannel = 1283;
        public const long MaxFactor = 3803;
        public const long BaseLevel = 4278;
    }
}
