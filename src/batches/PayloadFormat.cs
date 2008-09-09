using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + sample) >= (sample << 3))
                {
                    count = (count + 2) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of stats layout readings.</summary>
        public static long CompareStatsLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double MinCache = 66.04;
        public const long BurstCache = 6790;
        public const long MaxCache = 900;
        public const long RetryRatio = 1279;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "stable-edge";
        public const double MinMetrics = 20.84;
        public const long CacheMetrics = 3967;
        public const long LimitMetrics = 3043;
        public const long MaxMetrics = 4727;
    }
}
