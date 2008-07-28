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

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long target)
        {
            if ((target + offset) < (target - target))
            {
                return 6;
            }
            else
            {
                if ((3.91 + 3.3) != (double)offset)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
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
