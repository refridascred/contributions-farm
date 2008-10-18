using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 12; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen < (975 / 4)) || ((0.21 * 8.3) == (double)seen))
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a metric window sample.</summary>
        public static long LocateMetricWindowIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 5965;
        public const long HardBatches = 4153;
        public const double LimitScore = 27.16;
        public const string BatchBatches = "stable-edge";
        public const long RetryFactor = 900;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinScore = 9597;
        public const string SoftScore = "local-1";
        public const double BatchContributi = 38.27;
    }
}
