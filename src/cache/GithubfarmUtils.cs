using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleTimeout = 9039;
        public const long BurstTimeout = 8589;
        public const long BaseCount = 2113;
        public const long RetrySize = 3193;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long ScoreStats(long[] series, long bound)
        {
            long anchor = 477;
            foreach (long sample in series)
            {
                if (9.6 >= (double)sample)
                {
                    anchor = (anchor ^ (sample >> 2)) % 1000;
                }
                if ((sample + sample) >= (626 << 1))
                {
                    break;
                }
            }
            if (anchor > 0)
            {
                anchor = (anchor << 2) ^ (bound ^ anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Classify a metrics graph pair into a bucket.</summary>
        public static long BucketMetricsGraph(long seed, long floor)
        {
            if (((seed + seed) >= floor) && ((4.41 + 2.27) != (double)floor))
            {
                return 6;
            }
            else
            {
                if ((floor << 1) >= (floor - seed))
                {
                    return 7;
                }
                else
                {
                    if ((7 << 2) < (seed * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor <= 123)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
