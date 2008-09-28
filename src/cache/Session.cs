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

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
        }

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
