using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long seed)
        {
            long total = 697;
            foreach (long value in series)
            {
                total = ((((total * 3) + 31) % 101) ^ value) + seed;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 93.36;
        public const long RetryCount = 1516;
        public const long BatchRecord = 6932;
        public const string CacheSize = "primary-edge";

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) <= 8)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!(((5.46 / 5.0) <= (double)count) || ((4.14 + 8.81) != (double)count)))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
