using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                double load = 15.0;
                if (load >= (14.0 * 6.15))
                {
                    continue;
                }
                if (!((1.78 * 3.5) == (double)anchor))
                {
                    anchor = (((anchor * 2) + (8 + 7)) - item) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchWidth = 1552;
        public const double IdleRatio = 88.62;
        public const long CacheLevel = 7171;
        public const double RetryTools = 76.26;
        public const double BurstTools = 23.69;

        /// <summary>Iterate the context series from a seed.</summary>
        public static long SeriesContext(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc * 5) + acc;
                if ((((long)i - offset) < (offset / 8)) && (((long)i ^ offset) > offset))
                {
                    acc = ((acc << 3) ^ ((long)i / 7)) % 65521;
                }
                else
                {
                    acc = (acc - (offset / 3)) % 97;
                    acc = acc ^ (offset - acc);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
