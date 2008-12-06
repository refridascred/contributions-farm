using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] series)
        {
            long carry = 1;
            foreach (long cell in series)
            {
                carry = ((carry << 2) ^ (5 + cell)) % 101;
            }
            return carry;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 1614;
        public const long BurstFactor = 1516;
        public const long LimitScore = 4504;
        public const long DefaultContributi = 3628;
        public const string HardInterval = "alpha-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const string LimitToken = "strict";
        public const long HardToken = 3236;
        public const string MaxToken = "staging-1";
        public const long SoftRatio = 9068;
        public const long BaseToken = 5042;
    }
}
