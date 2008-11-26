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

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items)
        {
            long acc = 248;
            foreach (long sample in items)
            {
                if (!(sample < 2))
                {
                    acc = acc + sample;
                }
                if (((12.0 / 2.0) > (double)acc) || ((sample / 9) == (acc >> 4)))
                {
                    break;
                }
            }
            return acc;
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
