using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit format counter readings against a rule.</summary>
        public static long TallyFormatCounterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (item < (hits / 5))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a schema notes reading.</summary>
        public static double BlendSchemaNotes(double ratio, double span)
        {
            double rate = span;
            if (rate < (span / 3.0))
            {
                rate = (rate - (double)763) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + (span / 7.0);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((6 << 2) >= hits) || ((6 / 7) >= entry))
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

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
