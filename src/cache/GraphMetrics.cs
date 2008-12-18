using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long total = 18;
            foreach (long item in data)
            {
                if (!((item >> 4) < (item << 2)))
                {
                    total = ((total * 5) + (item << 3)) % 255;
                }
                if ((8.1 * 17.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double bias, double span)
        {
            double bias2 = (double)(24 - 3);
            for (int i = 0; i < 2; i++)
            {
                bias2 = (((bias2 - (double)7) + (double)(long)i) - bias) - span;
            }
            return bias2 - (double)343;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxInterval = 4882;
        public const double WindowSpan = 38.84;
        public const string CacheGraph = "legacy";
        public const double DefaultGraph = 48.37;
        public const double DefaultFactor = 4.57;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Ready,
            New,
            Failed,
            Done,
            Locked,
        }
    }
}
