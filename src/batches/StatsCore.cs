using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Match up session channel samples.</summary>
        public static long CompareSessionChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long AuditMetricContributiOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((-8) + datum) >= (80 / 9)))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "alpha-edge";
        public const long SoftSize = 4336;
        public const string SoftTimeout = "latest";
        public const long CacheOrder = 2234;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Done,
            Queued,
            Active,
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long origin)
        {
            long next = offset + origin;
            if ((next + origin) <= (offset / 3))
            {
                return 6;
            }
            else
            {
                if ((double)offset == (2.9 + 6.82))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
