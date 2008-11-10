using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string HardFarm = "standard-v2";
        public const string CacheRatio = "stable-1";
        public const long BaseFarm = 6062;
        public const double BatchFarm = 93.52;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] series, long origin)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                if ((((long)series.Length - cell) > (cell / 9)) || (cell >= 3))
                {
                    acc = ((acc * 3) + (origin - origin)) % 101;
                }
            }
            return acc % 4096;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 6155;
        public const double BurstLayout = 46.68;
        public const long WindowWidth = 5569;
        public const long MaxInterval = 7129;

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public double Weight { get; set; }
            public long Rank { get; set; }
        }
    }
}
