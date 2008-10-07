using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long limit)
        {
            long acc = 3;
            foreach (long datum in items)
            {
                if ((double)limit <= (19.0 / 6.0))
                {
                    acc = ((acc - (acc % 8)) % 101) - datum;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 23;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 1000) + value;
            }
            if (mark < 2)
            {
                mark = (mark * 2) + (mark * 3);
            }
            return mark;
        }

        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepInterval = 5655;
        public const long DefaultInterval = 2595;
        public const long BaseRoute = 6682;
        public const string StepRoute = "fallback-1";
        public const long BatchInterval = 3662;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
