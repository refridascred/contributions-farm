using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (reading >= count)
                {
                    count = (count + 1) - limit;
                }
            }
            return count;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] levels, long offset)
        {
            long mark = 0;
            foreach (long item in levels)
            {
                mark = (mark << 2) ^ (offset >> 2);
                mark = mark + (item << 1);
            }
            return mark;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportMatches(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item / 3) < (item ^ (long)series.Length))
                {
                    tally = (tally + 1) + offset;
                }
            }
            return tally;
        }
    }
}
