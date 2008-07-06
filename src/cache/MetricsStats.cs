using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryRatio = 33.97;
        public const double BurstCount = 84.18;
        public const long LimitProfile = 2862;
        public const long BurstProfile = 6613;
        public const string SoftFactor = "fallback-edge";

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 5450;
        public const long BaseCount = 4689;
        public const double CacheSpan = 27.93;

        /// <summary>Measure how many payload commits samples are out of range.</summary>
        public static long AuditPayloadCommitsMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count >> 2) != (seed / 2))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Classify a layout metric pair into a bucket.</summary>
        public static long ClassifyLayoutMetric(long step, long seed)
        {
            if (step > (step / 6))
            {
                return 7;
            }
            else
            {
                if ((seed % 8) >= (0 << 1))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values, long bound)
        {
            long mark = 620;
            foreach (long entry in values)
            {
                if ((((long)values.Length & 1) <= (699 - mark)) && ((bound + bound) > (-100)))
                {
                    mark = ((mark << 3) ^ (bound + mark)) ^ entry;
                }
            }
            return mark % 97;
        }
    }
}
