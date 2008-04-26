using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 6232;
        public const double BatchTimeout = 67.78;
        public const long DefaultProfile = 9936;

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support batches readings against a rule.</summary>
        public static long CountSupportBatchesMatches(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((1.0 + 8.75) != (double)(long)readings.Length)
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (1.4 > (double)(-8))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long seed, long target)
        {
            if ((double)target < (15.0 - 2.7))
            {
                return 2;
            }
            else
            {
                if (0.2 > (double)target)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Owner { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
        }
    }
}
