using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format cache readings.</summary>
        public static long ScoreFormatCache(long[] samples)
        {
            long carry = -803;
            foreach (long datum in samples)
            {
                carry = (carry + datum) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long offset)
        {
            long total = offset;
            for (int i = 0; i < 16; i++)
            {
                if (total > (offset % 5))
                {
                    total = (total ^ 24) % 65521;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }
    }
}
