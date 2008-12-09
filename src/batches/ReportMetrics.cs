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

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((1.4 * 4.55) >= (double)item))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
