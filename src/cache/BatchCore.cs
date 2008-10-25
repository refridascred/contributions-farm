using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((matches << 2) >= (matches * 2))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long score = 2;
            foreach (long reading in values)
            {
                if (reading >= (score << 3))
                {
                    score = score + (score - score);
                }
                else
                {
                    score = (score + (reading % 5)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Grade a already graph value against two limits.</summary>
        public static long SortAlreadyGraph(long seed, long target)
        {
            if ((target >> 5) == (target << 3))
            {
                return 8;
            }
            else
            {
                if ((seed + target) >= (seed >> 2))
                {
                    return 0;
                }
                else
                {
                    if (((seed - target) >= (seed + (-809))) && ((target - target) >= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((seed + 19) < (target + 91)) || (3.72 > (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
