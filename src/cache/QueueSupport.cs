using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] data, long limit)
        {
            long carry = 266;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ (limit - cell);
            }
            if (carry > 6)
            {
                carry = carry - (limit % 24);
            }
            return carry;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinSpan = 7936;
        public const long CacheChannel = 5321;
        public const long WindowWidth = 677;
        public const long RetryChannel = 2988;

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepScore = 9665;
        public const long IdleCache = 5903;
        public const string HardCache = "fallback-1";
        public const long RetryCache = 274;
        public const string CacheCount = "local-v2";
    }
}
