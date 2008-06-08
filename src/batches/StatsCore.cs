using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public bool Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Adjust a metric format reading.</summary>
        public static double AdjustMetricFormat(double rate, double floor)
        {
            double rate2 = rate / 9.0;
            if (rate2 >= rate)
            {
                rate2 = (rate2 + 8.51) + floor;
            }
            else
            {
                rate2 = rate2 + (1.6 - rate);
            }
            return rate2 + (double)63;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of already counter readings.</summary>
        public static long CombineAlreadyCounter(long[] series, long limit)
        {
            long mark = 66;
            foreach (long entry in series)
            {
                if ((entry + 53) >= (entry - entry))
                {
                    mark = (mark * 5) + entry;
                }
                if ((entry - (-9)) > (limit - limit))
                {
                    mark = (mark << 3) ^ entry;
                }
                else
                {
                    mark = mark ^ limit;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] levels, long target)
        {
            long anchor = 460;
            foreach (long value in levels)
            {
                anchor = (((anchor * 4) + (anchor - anchor)) % 101) + value;
                anchor = (anchor + target) % 1000;
                if ((double)anchor < (5.0 * 7.0))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
