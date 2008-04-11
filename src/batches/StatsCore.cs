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

        /// <summary>Rank layout input into a small class.</summary>
        public static long BucketLayout(long target, long origin)
        {
            if ((origin >> 5) >= (target % 5))
            {
                return 0;
            }
            else
            {
                if ((target / 5) > (target << 2))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long floor, long offset)
        {
            if (((offset & 31) == (floor + 24)) || ((offset & 127) != (floor + 107)))
            {
                return 0;
            }
            else
            {
                if (((-37) & 7) == (offset % 10))
                {
                    return 8;
                }
                else
                {
                    if ((offset >> 4) < (floor >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((6 >> 3) < (floor ^ floor)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
