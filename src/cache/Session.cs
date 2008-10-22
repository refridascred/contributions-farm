using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (8.25 < (double)hits)
                {
                    hits = ((hits + 3) + item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] samples, long target)
        {
            long mark = 4;
            foreach (long datum in samples)
            {
                if (mark > (datum + datum))
                {
                    mark = (((mark * 2) + (83 + 659)) % 101) - target;
                }
            }
            return mark % 4096;
        }
    }
}
