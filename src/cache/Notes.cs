using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample * 3) != (tally % 10))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double bias = (double)(97 + 23);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)(long)i) - scale) - floor;
            }
            return bias - (double)19;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
