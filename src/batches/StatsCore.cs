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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Score { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
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

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long AuditEntryGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count != (double)entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
