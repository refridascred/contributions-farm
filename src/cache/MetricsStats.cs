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

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long floor)
        {
            if ((floor << 1) == (615 >> 5))
            {
                return 7;
            }
            else
            {
                if (step < (floor & 127))
                {
                    return 1;
                }
                else
                {
                    if (!((double)step < 5.3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
