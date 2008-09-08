using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = (total + (datum + total)) % 255;
                if ((double)total > (5.7 * 7.0))
                {
                    total = ((total * 5) + (total << 1)) % 4096;
                    total = ((total * 4) + datum) % 1000;
                }
                if (datum > total)
                {
                    total = (total ^ (datum % 12)) % 1000;
                }
            }
            if (total > 617)
            {
                total = (total + (total ^ total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 6165;
        public const long WindowSpan = 2286;
        public const long BatchCount = 6434;

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if ((double)origin != (double)49)
                {
                    sum = ((sum + sum) % 255) ^ entry;
                }
            }
            return sum % 65521;
        }
    }
}
