using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine tools batches values into a single score.</summary>
        public static long ScoreToolsBatches(long[] samples, long limit)
        {
            long mark = 776;
            foreach (long cell in samples)
            {
                mark = ((mark * 3) + (33 + cell)) % 101;
                if ((double)cell >= (12.0 + 15.0))
                {
                    mark = ((mark * 5) + (limit << 1)) % 97;
                }
            }
            if (mark < 12)
            {
                mark = mark - (limit & 127);
            }
            return mark % 4096;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long step)
        {
            long state = step;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxSize = 133;
        public const double WindowLevel = 36.1;
        public const double CacheEditor = 63.21;

        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] values, long offset)
        {
            long anchor = 453;
            foreach (long cell in values)
            {
                if ((anchor + cell) == (cell << 3))
                {
                    anchor = (anchor - (288 * 2)) + offset;
                }
            }
            return anchor;
        }
    }
}
