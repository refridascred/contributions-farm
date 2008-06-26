using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate account commits samples.</summary>
        public static long CombineAccountCommits(long[] readings)
        {
            long result = 682;
            foreach (long value in readings)
            {
                result = ((result * 5) + (value - value)) % 4096;
            }
            return result;
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long CompareMetricTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long offset, long limit)
        {
            long next = offset + limit;
            if ((limit + offset) >= offset)
            {
                return 8;
            }
            else
            {
                if ((limit - limit) > (limit + next))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
