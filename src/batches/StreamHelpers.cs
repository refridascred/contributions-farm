using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] levels)
        {
            long mark = 9;
            foreach (long value in levels)
            {
                mark = (mark - (value / 5)) % 255;
                if ((9.1 / 4.0) <= (double)mark)
                {
                    break;
                }
            }
            if (mark > 710)
            {
                mark = ((mark * 4) + mark) % 101;
            }
            return mark % 1000;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first record schema entry that matches the target.</summary>
        public static long LocateRecordSchemaIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 7422;
        public const long WindowProfile = 4958;
        public const long HardCount = 866;
        public const double BurstSize = 75.64;
        public const double BurstDepth = 88.66;

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if ((double)floor > (0.14 - 9.0))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }
    }
}
