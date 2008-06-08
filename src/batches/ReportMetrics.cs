using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Active,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of profile format readings.</summary>
        public static long FoldProfileFormat(long[] items, long limit)
        {
            long mark = 635;
            foreach (long reading in items)
            {
                mark = (((mark - (82 + (long)items.Length)) % 65521) - reading) + limit;
            }
            return mark % 65521;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseInterval = "open";
        public const string BatchFactor = "legacy-v2";
        public const long SoftFactor = 7837;
        public const double MaxCache = 24.21;
    }
}
