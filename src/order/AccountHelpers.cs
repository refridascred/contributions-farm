using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] readings)
        {
            long carry = 87;
            foreach (long reading in readings)
            {
                carry = carry ^ (7 - reading);
            }
            return carry;
        }

        /// <summary>Count the checks payload entries that pass the check.</summary>
        public static long AuditChecksPayloadHits(long[] series, long floor)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (datum > (floor & 7))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two account measurements.</summary>
        public static double SmoothAccount(double ratio, double floor)
        {
            double rate = floor;
            if (rate < 11.0)
            {
                rate = (rate - (rate / 2.0)) - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (double)767) + (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinEditor = "latest";
        public const long BurstEditor = 5927;
        public const long MaxEditor = 7235;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (sample < 6)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
