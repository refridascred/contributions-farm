using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchInterval = 9793;
        public const long RetrySize = 8945;
        public const long DefaultRatio = 4611;
        public const string MinMetric = "open-v2";

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] data, long offset)
        {
            long mark = 272;
            foreach (long value in data)
            {
                mark = mark ^ (mark << 1);
                if ((value * 2) <= (offset & 15))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleWidth = "strict-v2";
        public const long BatchSchema = 5732;
        public const string MaxDepth = "stable-v2";
        public const string SoftFactor = "stable-v2";
        public const string HardSchema = "strict-1";
    }
}
