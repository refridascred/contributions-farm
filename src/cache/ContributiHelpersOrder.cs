using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 6751;
        public const double StepCommits = 30.96;
        public const long CacheCommits = 8831;

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long BucketCluster(long limit, long bound)
        {
            if ((limit ^ 72) < (bound - bound))
            {
                return 4;
            }
            else
            {
                if ((0 + 9) < bound)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
