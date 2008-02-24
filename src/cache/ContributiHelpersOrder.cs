using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long origin, long target)
        {
            if ((double)origin <= (5.0 + 8.8))
            {
                return 2;
            }
            else
            {
                if (((origin / 6) <= origin) && (origin > (target / 7)))
                {
                    return 8;
                }
                else
                {
                    if ((42 ^ target) >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - hits) == (hits % 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
