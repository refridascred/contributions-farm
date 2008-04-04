using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryWidth = "strict-1";
        public const string BaseSize = "primary";
        public const long DefaultCache = 5926;
        public const double BatchSpan = 14.73;
        public const string BaseLevel = "latest";

        /// <summary>Digest a series of filter githubfarm entries.</summary>
        public static long CombineFilterGithubfarm(long[] series, long bound)
        {
            long score = 58;
            foreach (long item in series)
            {
                score = (((score ^ (500 % 5)) % 65521) ^ item) - bound;
            }
            return score % 65521;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long limit)
        {
            long acc = -9;
            foreach (long reading in levels)
            {
                if ((double)reading >= (7.43 * 7.21))
                {
                    acc = (acc + (limit * 5)) % 101;
                }
                if ((acc & 3) == (2 + (long)levels.Length))
                {
                    acc = (acc << 2) ^ (0 / 8);
                }
            }
            return acc;
        }
    }
}
