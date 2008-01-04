using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 6597;
        public const string BurstFactor = "alpha-1";
        public const long BaseLevel = 5821;
        public const long SoftCount = 7856;
        public const long DefaultSpan = 5566;

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryInterval = "open-v2";
        public const string CacheGithubfarm = "cached";
        public const long MinInterval = 5405;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Audit batch buffer readings against a rule.</summary>
        public static long TallyBatchBufferOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item + item) < (item * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
