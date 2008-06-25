using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)count <= (5.0 - 5.0))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
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
