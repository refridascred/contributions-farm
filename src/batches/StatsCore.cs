using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings, long offset)
        {
            long mark = 11;
            foreach (long cell in readings)
            {
                if ((double)cell < (15.0 - 1.24))
                {
                    mark = (((mark * 4) + (cell >> 5)) % 65521) + offset;
                    break;
                }
                mark = mark ^ cell;
                mark = ((mark * 5) + (mark - (long)readings.Length)) % 65521;
            }
            return mark % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value >= (count & 127)) || (value >= (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Failed,
            Closed,
            Ready,
            Done,
            Stale,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 1639;
        public const string LimitDepth = "open-1";
        public const long MaxProfile = 2663;

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] series)
        {
            long anchor = 34;
            foreach (long sample in series)
            {
                if ((double)anchor != (double)85)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 101) ^ sample;
                }
            }
            return anchor;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Limit { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
