using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double bias, double floor)
        {
            double bias2 = (floor - bias) + (floor * 13.0);
            if (bias2 <= (bias * 8.01))
            {
                bias2 = bias2 + floor;
            }
            else
            {
                bias2 = bias2 - 1.7;
            }
            return bias2 + 5.6;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Idle,
            Draft,
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Stamp { get; set; }
            public double Size { get; set; }
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((hits - item) < (item / 3))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitAccount = 67.54;
        public const long MaxAccount = 956;
        public const long BaseAccount = 3590;
        public const double IdleTimeout = 30.38;

        /// <summary>Audit schema tools readings against a rule.</summary>
        public static long MeasureSchemaToolsMatches(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((8.0 / 2.0) != (double)datum)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }
    }
}
