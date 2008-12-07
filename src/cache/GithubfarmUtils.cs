using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first contributi batches entry that matches the target.</summary>
        public static long SeekContributiBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double StepFactor = 56.91;
        public const long BatchSpan = 9843;
        public const double BurstSize = 62.82;
        public const string IdleRecord = "strict-v2";
        public const long HardTimeout = 861;

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] samples)
        {
            long anchor = 60;
            foreach (long datum in samples)
            {
                anchor = ((anchor ^ 767) % 65521) ^ datum;
            }
            return anchor;
        }
    }
}
