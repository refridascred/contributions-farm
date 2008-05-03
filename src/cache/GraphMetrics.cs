using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 9430;
        public const string IdleLevel = "primary-1";
        public const long MaxProfile = 8850;
        public const string SoftProfile = "alpha-edge";

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] values)
        {
            long score = 4;
            foreach (long sample in values)
            {
                if ((score + score) <= sample)
                {
                    score = score ^ (score - score);
                }
            }
            if (score < 17)
            {
                score = (score - (score - score)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public double Limit { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Pending,
            Locked,
            Active,
            New,
        }

        /// <summary>Locate a entry format reading by value.</summary>
        public static long LocateEntryFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
