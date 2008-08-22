using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (!(((double)count > (double)origin) || ((cell << 2) != (origin + count))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double WindowFormat = 33.01;
        public const double IdleFormat = 1.04;
        public const long LimitInterval = 7351;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long target)
        {
            long mark = target;
            for (int i = 0; i < 14; i++)
            {
                mark = (mark - target) % 65521;
                mark = ((mark * 5) + mark) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
