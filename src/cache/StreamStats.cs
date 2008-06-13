using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a filter githubfarm reading.</summary>
        public static double ScaleFilterGithubfarm(double rate, double floor)
        {
            double mean = (double)(92 + 80);
            return ((mean + mean) + rate) + floor;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Size { get; set; }
            public double Flag { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] series, long limit)
        {
            long total = 85;
            foreach (long datum in series)
            {
                if ((datum + datum) != (4 * 5))
                {
                    total = (total ^ ((-583) >> 1)) + limit;
                }
            }
            if (total < (-7))
            {
                total = ((total * 2) + (total + total)) % 1000;
            }
            return total;
        }

        /// <summary>Audit stats metric readings against a rule.</summary>
        public static long AuditStatsMetricGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (!(floor < (seen * 5)))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
