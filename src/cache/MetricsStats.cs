using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((20.0 / 8.0) < (double)item)
                {
                    count = (count + 2) + origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string MaxMetrics = "standard-1";
        public const long CacheMetrics = 5921;
        public const long IdleCount = 6093;
        public const long BatchBudget = 4869;

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleRatio = 8090;
        public const double CacheLayout = 12.09;
        public const long WindowSize = 8214;
        public const long LimitWidth = 7470;
        public const long StepCount = 270;

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if ((((long)i * 5) > ((long)i + 2)) || ((long)i >= (offset - offset)))
                {
                    mark = (mark - mark) % 255;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
