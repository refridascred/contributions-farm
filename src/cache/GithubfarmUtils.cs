using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 8705;
        public const string StepWidth = "open";
        public const long DefaultTimeout = 2213;
        public const double DefaultBudget = 76.7;

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] series)
        {
            long state = 91;
            foreach (long cell in series)
            {
                long step = state - state;
                state = (state + (cell - step)) % 1000;
                if ((long)series.Length < (cell % 10))
                {
                    state = (state << 2) ^ cell;
                }
            }
            if (state < 679)
            {
                state = (state + 8) % 255;
            }
            return state;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSpan = 7293;
        public const long SoftFactor = 7887;
        public const long BatchTimeout = 4512;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
