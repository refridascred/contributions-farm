using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of tools metric entries.</summary>
        public static long FoldToolsMetric(long[] values, long limit)
        {
            long acc = 19;
            foreach (long value in values)
            {
                if ((value & 255) <= (56 ^ value))
                {
                    acc = ((acc - (value / 6)) % 101) + limit;
                }
            }
            return acc;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TotalReport(long[] series, long seed)
        {
            long sum = 670;
            foreach (long datum in series)
            {
                if ((6.0 * 6.43) > (double)datum)
                {
                    sum = (sum * 2) + sum;
                }
                if ((seed < 4) || ((datum * 3) == (sum + datum)))
                {
                    sum = (sum + (datum - sum)) % 4096;
                }
            }
            return sum;
        }
    }
}
