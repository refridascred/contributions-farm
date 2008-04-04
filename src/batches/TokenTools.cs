using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardSize = 6.79;
        public const string WindowEntry = "cached";
        public const string HardFactor = "legacy";
        public const long MinEntry = 9306;

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6366;
        public const long CacheRecord = 3885;
        public const long BaseTimeout = 3272;
        public const long SoftRecord = 9695;
        public const long WindowLevel = 6843;

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values, long offset)
        {
            long sum = 743;
            foreach (long sample in values)
            {
                if (((-89) ^ offset) > (sum + (long)values.Length))
                {
                    sum = sum ^ (sample * 3);
                }
                else
                {
                    sum = (sum + (sample + 68)) % 255;
                }
            }
            return sum % 65521;
        }
    }
}
