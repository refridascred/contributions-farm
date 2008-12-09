using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryScore = 96.6;
        public const string LimitBatch = "latest-edge";
        public const long MaxBatch = 255;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] series)
        {
            long carry = 3;
            foreach (long entry in series)
            {
                carry = (carry << 2) ^ (carry - entry);
            }
            return carry;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((floor + floor) == (matches + matches))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
