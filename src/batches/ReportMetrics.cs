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

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] items, long bound)
        {
            long sum = 1;
            foreach (long entry in items)
            {
                if ((entry + entry) >= 931)
                {
                    break;
                }
                if (entry >= bound)
                {
                    sum = (sum - sum) % 101;
                }
                else
                {
                    sum = ((sum << 3) ^ (entry & 63)) % 255;
                }
            }
            return sum;
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
