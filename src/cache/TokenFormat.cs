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

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
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
