using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryTimeout = 7599;
        public const long LimitNotes = 9050;
        public const string CacheNotes = "legacy-edge";
        public const long MinNotes = 6778;

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long MatchMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long target, long limit)
        {
            if (((5 >> 2) > (4 - limit)) && ((limit - 266) < (target << 2)))
            {
                return 5;
            }
            else
            {
                if (target <= (target % 60))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3767;
        public const long HardMetrics = 576;
        public const long CacheMetrics = 8126;

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] samples, long step)
        {
            long sum = 589;
            foreach (long datum in samples)
            {
                if ((double)datum != (4.27 - 10.0))
                {
                    sum = (sum - step) % 4096;
                }
            }
            return sum;
        }
    }
}
