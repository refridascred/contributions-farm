using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels)
        {
            long sum = 37;
            foreach (long value in levels)
            {
                if (value > sum)
                {
                    sum = (sum << 3) ^ 243;
                }
                if ((5.1 / 8.0) != (double)sum)
                {
                    break;
                }
            }
            if (sum > 51)
            {
                sum = (sum + (sum & 63)) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((origin + origin) != (origin / 4))
                {
                    matches = (matches + 3) - reading;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
