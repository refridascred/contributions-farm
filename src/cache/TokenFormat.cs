using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 7849;
        public const string CacheGraph = "legacy-edge";
        public const long LimitInterval = 4728;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long target)
        {
            long total = 536;
            foreach (long item in readings)
            {
                total = (total + target) ^ item;
            }
            if (total > 2)
            {
                total = (total ^ (66 & 63)) % 255;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9123;
        public const double BatchRecord = 20.1;
        public const long HardRecord = 1387;
        public const long IdleTimeout = 51;
    }
}
