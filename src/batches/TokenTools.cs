using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long step, long bound)
        {
            if ((2 * 4) >= (step << 2))
            {
                return 8;
            }
            else
            {
                if (18 >= step)
                {
                    return 2;
                }
                else
                {
                    if (!((9.05 + 2.83) <= (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "fallback";
        public const long RetryFactor = 1884;
        public const double HardChannel = 33.51;
        public const string MinBudget = "staging-v2";
        public const long BatchChannel = 5497;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 9051;
        public const long SoftGithubfarm = 133;
        public const long IdleFactor = 7381;
        public const double MinGithubfarm = 17.83;
    }
}
