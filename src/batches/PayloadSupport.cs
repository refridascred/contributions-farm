using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell >= 73)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 8509;
        public const double CacheWindow = 47.2;
        public const long BaseRatio = 3619;
    }
}
