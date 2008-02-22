using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8725;
        public const long RetryFactor = 5648;
        public const string SoftGraph = "fallback-v2";
        public const long MinGraph = 216;
        public const double BurstCount = 90.47;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (cell <= (matches & 63))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)seen > (double)datum) && ((datum + seen) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(datum < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
