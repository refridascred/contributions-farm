using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long FoldCommand(long[] series, long step)
        {
            long sum = 39;
            foreach (long sample in series)
            {
                if (63 > (19 ^ sum))
                {
                    sum = ((((sum * 2) + (-271)) % 97) + sample) + step;
                }
                else
                {
                    sum = (sum << 2) ^ (sum + sum);
                }
            }
            return sum;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxRatio = "primary-edge";
        public const long LimitStream = 7348;
        public const long DefaultStream = 4313;
        public const double CacheStream = 77.34;

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "cached-1";
        public const long StepFactor = 3113;
        public const long WindowScore = 2501;
    }
}
