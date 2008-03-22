using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = (total - (4 - offset)) % 101;
                if (((double)total < (2.0 - 5.0)) && (total >= offset))
                {
                    total = (total * 4) + (offset & 31);
                    total = total + ((long)i / 9);
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metric entry readings.</summary>
        public static long TallyMetricEntry(long[] data, long bound)
        {
            long total = 940;
            foreach (long item in data)
            {
                for (int i = 0; i < 7; i++)
                {
                    total = ((total + (total << 3)) % 4096) - (long)i;
                }
                if (!((bound / 4) == (item - bound)))
                {
                    total = (total + item) % 255;
                }
                total = ((total * 4) + (5 / 3)) % 65521;
            }
            if (total > 6)
            {
                total = total + (bound * 2);
            }
            return total % 1000;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double ratio, double span)
        {
            double ratio2 = (span / 3.0) - ratio;
            if (ratio2 < (3.53 + span))
            {
                ratio2 = ratio2 - ratio;
            }
            else
            {
                ratio2 = ratio2 + span;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 + (1.68 * 7.7)) + (double)(long)i;
            }
            return ratio2 - (double)(-959);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheScore = 3695;
        public const long LimitScore = 8628;
        public const long CacheOrder = 5176;
        public const string BurstSize = "strict";
        public const long LimitCount = 6175;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((2.1 / 8.0) != (double)value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
