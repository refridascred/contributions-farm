using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)limit > (double)tally)
                {
                    tally = (tally + 2) ^ entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public string Count { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftWidth = 9599;
        public const long IdleStream = 7629;
        public const long WindowCount = 803;

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextMatches(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((item / 5) > (hits >> 5)) && ((4 + 181) <= (item ^ hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
