using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the context profile entries that pass the check.</summary>
        public static long TallyContextProfileGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= (matches / 3))
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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = anchor - target;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
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
