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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

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
