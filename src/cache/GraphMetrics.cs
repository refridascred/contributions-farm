using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((datum - limit) > (limit / 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Total { get; set; } = "";
            public bool Region { get; set; }
            public double Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] levels)
        {
            long result = 135;
            foreach (long entry in levels)
            {
                result = (result + (entry >> 2)) % 4096;
                result = (result * 3) + (entry + entry);
            }
            return result % 65521;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Done,
            Pending,
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Synced,
            Locked,
            Pending,
            Draft,
        }
    }
}
