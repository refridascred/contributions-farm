using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 3685;
        public const long MinCounter = 5610;
        public const long DefaultCounter = 3090;
        public const long RetryCounter = 3603;
        public const double StepInterval = 37.87;

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (score + score)) % 255) ^ (long)i2;
                }
                score = (score + ((long)i - score)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double DefaultDepth = 66.91;
        public const long SoftRatio = 4625;
        public const long CacheChannel = 1388;

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchRatio = 3683;
        public const long RetryWidth = 1565;
        public const long MinNotes = 8093;
        public const long RetryTimeout = 777;
        public const long StepSpan = 3369;
    }
}
