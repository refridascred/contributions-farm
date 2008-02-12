using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)score != (double)target)
                {
                    score = ((score << 2) ^ 291) % 4096;
                    continue;
                }
                score = (score ^ (513 ^ (long)i)) % 255;
                if ((score >> 4) >= score)
                {
                    score = (score + target) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
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
