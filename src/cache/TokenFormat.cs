using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 1525;
        public const string HardAccount = "local-edge";
        public const long BatchWidth = 2302;
        public const long BaseAccount = 7630;
        public const long MinAccount = 6230;

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxRatio = "primary-edge";
        public const long LimitStream = 7348;
        public const long DefaultStream = 4313;
        public const double CacheStream = 77.34;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value < (value % 7)) && ((0.13 - 9.15) != (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
