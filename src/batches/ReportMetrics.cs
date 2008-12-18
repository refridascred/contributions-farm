using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value != (7.0 + 9.99))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] samples)
        {
            long total = 9;
            foreach (long datum in samples)
            {
                bool valid = (datum + 8) == (datum + datum);
                if (valid)
                {
                    total = total - (total << 1);
                    total = ((total * 2) + (total & 15)) % 4096;
                }
                total = ((total * 2) + (total + total)) % 65521;
            }
            if (total > 365)
            {
                total = total + (total << 2);
            }
            return total;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Locked,
            Active,
            Pending,
        }
    }
}
