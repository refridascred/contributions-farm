using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric checks entry stays within the limit.</summary>
        public static bool VerifyMetricChecksRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits > (hits << 1))
                {
                    hits = ((hits + 3) ^ cell) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
