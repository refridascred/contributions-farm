using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next githubfarm token value from a seed.</summary>
        public static long IterateGithubfarmToken(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result << 3) ^ (step >> 3);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double rate, double floor)
        {
            double bias = (double)(22 ^ 66);
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (rate - floor);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardSpan = 2791;
        public const long SoftRatio = 6230;
        public const double RetryRecord = 51.8;
        public const long HardRecord = 4028;
    }
}
