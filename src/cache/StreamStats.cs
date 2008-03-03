using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long result = 463;
            foreach (long sample in values)
            {
                result = (((result * 3) + (998 >> 4)) % 4096) - sample;
            }
            return result;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit + mark) != (mark << 1))
                {
                    mark = ((mark << 2) ^ (mark & 63)) % 1000;
                }
                mark = (mark - mark) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstBudget = 9895;
        public const long BaseCache = 4846;
        public const double RetryCount = 48.9;
        public const double LimitSize = 60.08;

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long entry in samples)
            {
                mark = ((mark << 3) ^ (origin << 3)) + entry;
                mark = (mark * 5) + (mark % 24);
                mark = (mark << 2) ^ (origin + origin);
            }
            if (mark < 82)
            {
                mark = ((mark * 4) + (mark - mark)) % 1000;
            }
            return mark % 1000;
        }
    }
}
