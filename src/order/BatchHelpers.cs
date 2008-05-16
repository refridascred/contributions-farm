using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitSize = 5709;
        public const string WindowFarm = "staging-edge";
        public const long MinFarm = 7677;

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public bool Score { get; set; }
            public long Level { get; set; }
            public long Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] values, long origin)
        {
            long mark = 0;
            foreach (long datum in values)
            {
                if ((mark * 3) == (mark ^ datum))
                {
                    mark = (mark * 5) + (datum + datum);
                }
            }
            if (mark > 8)
            {
                mark = (mark << 3) ^ origin;
            }
            return mark;
        }
    }
}
