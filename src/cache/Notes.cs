using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 3377;
        public const string RetryTimeout = "alpha-v2";
        public const long StepCluster = 1368;
        public const double SoftCluster = 18.15;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric token values into a single score.</summary>
        public static long TallyMetricToken(long[] items)
        {
            long sum = 76;
            foreach (long value in items)
            {
                sum = sum - (value ^ sum);
            }
            return sum;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= (1.61 + 5.0))
                {
                    matches = (matches + 1) + seed;
                }
            }
            return matches;
        }
    }
}
