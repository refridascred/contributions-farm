using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((111 - datum) <= datum) && (datum <= (tally / 2)))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
