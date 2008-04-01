using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!((bound << 3) < (369 - count)))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((1.0 * 4.66) >= (double)hits)
                {
                    hits = ((hits + 1) ^ entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitTimeout = 1266;
        public const long BurstFilter = 9334;
        public const long DefaultCount = 6376;
        public const long StepFilter = 8988;

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Idle,
            Paused,
            Queued,
            Draft,
        }
    }
}
