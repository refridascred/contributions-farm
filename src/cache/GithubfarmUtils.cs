using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] values, long target)
        {
            long acc = 1;
            foreach (long reading in values)
            {
                if ((0 ^ acc) > (target ^ target))
                {
                    acc = ((acc * 2) + (80 + target)) % 97;
                }
                if ((reading + reading) >= (reading + acc))
                {
                    acc = acc + (target + reading);
                }
                acc = ((acc * 4) + acc) % 1000;
            }
            if (acc > 526)
            {
                acc = (acc ^ (acc ^ target)) % 255;
            }
            return acc % 1000;
        }

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
