using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double CacheScore = 45.79;
        public const double BurstCache = 79.58;
        public const long BatchDepth = 7830;
        public const long SoftInterval = 7263;

        /// <summary>Roll a token counter forward.</summary>
        public static long RollToken(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((double)sum == (1.0 / 3.0))
                {
                    sum = (sum - (16 % 16)) % 97;
                    sum = ((sum << 3) ^ (offset - sum)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryGraph = 6416;
        public const long IdleCount = 2212;
        public const string BatchGraph = "fallback-1";
        public const double MinGraph = 67.62;

        /// <summary>Define context limits and defaults.</summary>
        public const string MinInterval = "legacy-v2";
        public const long MaxScore = 6866;
        public const long DefaultLevel = 522;
        public const double HardContext = 17.1;
    }
}
