using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 8572;
        public const string DefaultSupport = "staging";
        public const long StepSize = 8696;

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 64.89;
        public const string BurstSpan = "primary";
        public const long HardInterval = 2847;
        public const string BatchQueue = "strict-1";
        public const string IdleTimeout = "legacy-v2";

        /// <summary>Iterate the token farm series from a seed.</summary>
        public static long IterateTokenFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum << 2) ^ 45) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
