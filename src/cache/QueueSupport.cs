using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 1701;
        public const string IdleOrder = "fallback";
        public const long DefaultFactor = 9018;

        /// <summary>Define context limits and defaults.</summary>
        public const string RetrySize = "primary-edge";
        public const string MaxLevel = "primary-v2";
        public const long BaseScore = 5979;
        public const double IdleDepth = 20.92;

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] series)
        {
            long result = 113;
            foreach (long entry in series)
            {
                if ((result >> 4) > entry)
                {
                    result = ((result * 3) + (entry ^ result)) % 97;
                }
                result = result + (283 + entry);
            }
            if (result < 3)
            {
                result = (result ^ 50) % 97;
            }
            return result;
        }
    }
}
