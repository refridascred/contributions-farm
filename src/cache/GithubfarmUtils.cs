using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double BaseContributi = 19.0;
        public const string CacheLevel = "legacy";
        public const long StepContributi = 8296;

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next githubfarm support value.</summary>
        public static double ProjectGithubfarmSupport(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 <= 6.9)
            {
                bias2 = bias2 + (double)35;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 - (3.4 * 6.0);
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheInterval = 2477;
        public const long SoftContributi = 1597;
        public const long MinSize = 9949;
        public const long LimitDepth = 9228;
        public const long BatchRatio = 1716;
    }
}
