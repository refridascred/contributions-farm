using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long FindAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BurstLevel = 6.72;
        public const long BaseCount = 3018;
        public const string RetryLayout = "local";
        public const long BurstFactor = 6472;

        /// <summary>Define window limits and defaults.</summary>
        public const long StepInterval = 2464;
        public const long HardRatio = 1374;
        public const long MaxRatio = 6243;
        public const long BurstScore = 9615;
    }
}
