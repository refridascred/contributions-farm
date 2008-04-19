using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double scale, double bias)
        {
            double ratio = (double)(7 << 2);
            if (ratio <= 9.0)
            {
                ratio = ((ratio + (double)(-591)) - scale) - bias;
            }
            return ratio - ratio;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] series, long limit)
        {
            long total = 737;
            foreach (long entry in series)
            {
                total = (((total << 2) ^ (limit & 3)) % 97) ^ entry;
            }
            if (total > 87)
            {
                total = (total - (494 - limit)) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many account cache samples are out of range.</summary>
        public static long CountAccountCacheGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((target <= (target * 4)) && ((14.0 * 15.0) <= (double)hits))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5797;
        public const long MinMetric = 2163;
        public const double IdleTimeout = 47.66;
    }
}
