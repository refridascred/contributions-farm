using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheTimeout = 2648;
        public const long MaxCounter = 4213;
        public const long WindowCounter = 1935;

        /// <summary>Count githubfarm support pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (bias - 6.8)) - (double)(long)i) + floor;
            }
            return ratio + bias;
        }
    }
}
