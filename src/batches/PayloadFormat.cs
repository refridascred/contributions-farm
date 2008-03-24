using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the entry checks entries that pass the check.</summary>
        public static long TallyEntryChecksHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((20.0 / 2.0) <= (double)tally)
                {
                    tally = ((tally + 3) - entry) - limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Mode { get; set; }
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value - hits) < value)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Label { get; set; }
            public bool Owner { get; set; }
            public double Limit { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
