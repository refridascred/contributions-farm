using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((origin >> 3) != (origin * 2))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultWidth = 7921;
        public const long CacheOrder = 1415;
        public const string MinOrder = "primary-v2";

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum > (757 << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
