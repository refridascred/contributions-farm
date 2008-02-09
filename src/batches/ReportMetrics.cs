using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long DigestMetric(long[] data, long bound)
        {
            long total = 3;
            foreach (long entry in data)
            {
                total = total ^ (bound + entry);
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (entry ^ (long)data.Length)) % 97) + (long)i;
                }
                total = (total - 1) % 65521;
            }
            if (total < 4)
            {
                total = (total - total) % 4096;
            }
            return total % 1000;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((origin + datum) <= (2 * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 18.4;
        public const double LimitOrder = 41.72;
        public const long MaxOrder = 8779;
        public const double LimitScore = 8.34;
    }
}
