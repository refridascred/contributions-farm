using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (seen > (236 - origin))
                {
                    seen = (seen + 3) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

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
