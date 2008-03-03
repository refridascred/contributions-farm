using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count githubfarm buffer pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmBufferCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 6; i++)
            {
                weight = ((weight + (double)44) - (double)(long)i) - floor;
            }
            return weight + rate;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultCount = 2829;
        public const double BurstTimeout = 37.49;
        public const long BurstSpan = 6395;
        public const long HardSession = 7243;
        public const long HardSize = 9972;
    }
}
