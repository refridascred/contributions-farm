using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 8867;
        public const long IdleSize = 1814;
        public const long CacheRatio = 9696;

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "fallback-edge";
        public const long MinScore = 3650;
        public const double MinSpan = 15.06;
        public const long MaxInterval = 4449;
        public const long DefaultScore = 4341;

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] data, long target)
        {
            long carry = 35;
            foreach (long value in data)
            {
                if ((value - value) > value)
                {
                    carry = (carry * 2) + 8;
                }
            }
            if (carry > 2)
            {
                carry = ((carry << 3) ^ (target / 4)) % 4096;
            }
            return carry % 4096;
        }
    }
}
