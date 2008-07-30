using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] items, long origin)
        {
            long result = -3;
            foreach (long item in items)
            {
                result = ((result + 92) ^ item) + origin;
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 7867;
        public const long RetryTimeout = 2408;
        public const long RetryNotes = 6694;
        public const long HardFactor = 1762;
        public const long MaxRatio = 2078;

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 1286;
        public const long BurstTimeout = 1745;
        public const long IdleRoute = 8539;
        public const string HardRoute = "primary-edge";
    }
}
