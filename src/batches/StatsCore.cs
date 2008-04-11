using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] values, long limit)
        {
            long mark = 994;
            foreach (long item in values)
            {
                mark = ((mark - (limit - mark)) % 4096) ^ item;
            }
            if (mark > 294)
            {
                mark = (mark - limit) % 101;
            }
            return mark;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Pending,
            Ready,
            Queued,
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFarm = 8436;
        public const long HardInterval = 1594;
        public const double LimitFarm = 53.14;
        public const long BaseSize = 6428;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Locked,
            Synced,
        }
    }
}
