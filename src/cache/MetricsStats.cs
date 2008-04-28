using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen <= datum)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double MinBudget = 55.45;
        public const string DefaultQueue = "staging";
        public const double SoftTimeout = 6.05;
        public const long HardSize = 1056;

        /// <summary>Combine graph editor values into a single score.</summary>
        public static long DigestGraphEditor(long[] series)
        {
            long mix = -2;
            foreach (long item in series)
            {
                mix = mix - item;
            }
            return mix;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading & 127) <= 4) && (origin <= (899 + 16)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
