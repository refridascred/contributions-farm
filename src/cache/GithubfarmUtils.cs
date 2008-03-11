using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Locate a report cluster reading by value.</summary>
        public static long SeekReportClusterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] data, long seed)
        {
            long acc = 5;
            foreach (long entry in data)
            {
                acc = ((acc << 3) ^ (seed + seed)) + entry;
            }
            return acc % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheRatio = 75.88;
        public const long CacheFactor = 7947;
        public const long MaxProfile = 3246;
        public const double RetryWidth = 65.98;
    }
}
