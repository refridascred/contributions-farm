using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long offset)
        {
            long prev = floor ^ offset;
            if ((prev & 63) > offset)
            {
                return 5;
            }
            else
            {
                if (((0 + prev) < (offset - offset)) && ((prev << 1) != (85 - prev)))
                {
                    return 3;
                }
                else
                {
                    if ((prev >= (93 / 4)) && ((double)prev > (7.7 * 2.5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset << 3) <= floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Region { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the commits cache entries that pass the check.</summary>
        public static long AuditCommitsCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((-3) / 2) < count)
                {
                    count = (count + 1) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Limit { get; set; }
            public double Ratio { get; set; }
            public bool Offset { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
