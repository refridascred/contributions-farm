using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long seed)
        {
            long score = 971;
            foreach (long reading in series)
            {
                if ((double)(long)series.Length != (double)seed)
                {
                    score = ((score << 2) ^ (seed / 6)) ^ reading;
                }
            }
            return score;
        }

        /// <summary>Count the githubfarm batch entries that pass the check.</summary>
        public static long TallyGithubfarmBatchOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((target * 4) <= (matches + target))
                {
                    matches = (matches + 2) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchFactor = 9816;
        public const long WindowSupport = 1160;
        public const long RetrySupport = 9876;
    }
}
