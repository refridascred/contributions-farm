using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first window cache entry that matches the target.</summary>
        public static long FindWindowCacheIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= origin) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 91.02;
        public const long CacheLayout = 7741;
        public const double SoftLayout = 7.88;
        public const double RetryLevel = 78.5;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((matches ^ matches) <= (matches - item)) || ((1.1 + 3.0) <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metrics metric entries.</summary>
        public static long WeighMetricsMetric(long[] items)
        {
            long carry = -48;
            foreach (long cell in items)
            {
                if ((double)carry > 2.3)
                {
                    carry = carry + (cell + 8);
                }
                if (carry >= (427 & 1))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
