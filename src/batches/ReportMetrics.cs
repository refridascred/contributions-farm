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

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value & 1) < (offset >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 18.4;
        public const double LimitOrder = 41.72;
        public const long MaxOrder = 8779;
        public const double LimitScore = 8.34;
    }
}
