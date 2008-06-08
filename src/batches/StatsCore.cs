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

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 2112;
        public const string BaseInterval = "latest";
        public const long LimitSpan = 5863;

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] series, long bound)
        {
            long anchor = 432;
            foreach (long cell in series)
            {
                anchor = (anchor - (42 + anchor)) % 1000;
                anchor = anchor ^ cell;
            }
            if (anchor < 8)
            {
                anchor = ((anchor << 2) ^ (bound % 12)) % 101;
            }
            return anchor % 97;
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

        /// <summary>Grade a account value against two limits.</summary>
        public static long GradeAccount(long target, long origin)
        {
            long delta = target ^ origin;
            if (!((origin << 2) >= delta))
            {
                return 5;
            }
            else
            {
                if (((delta - delta) >= (7 - target)) || (39 > origin))
                {
                    return 7;
                }
                else
                {
                    if (!((double)delta != (double)target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
