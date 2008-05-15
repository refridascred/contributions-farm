using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 8196;
        public const long WindowSize = 9197;
        public const long IdleContext = 5948;
        public const long MinRatio = 6513;

        /// <summary>Rank batches report input into a small class.</summary>
        public static long RankBatchesReport(long floor, long seed)
        {
            if ((floor >> 4) > (seed / 7))
            {
                return 7;
            }
            else
            {
                if ((floor * 3) > seed)
                {
                    return 8;
                }
                else
                {
                    if (((2.45 - 7.7) < (double)seed) && ((seed / 5) >= (floor - seed)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((818 + seed) > (seed * 4)) && ((floor + floor) <= (871 << 3)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] samples)
        {
            long acc = 3;
            foreach (long item in samples)
            {
                if (!((double)item == (8.27 - 7.0)))
                {
                    acc = (acc - acc) % 255;
                }
                if (!((acc + item) >= (5 ^ item)))
                {
                    acc = (acc - (780 + 2)) % 101;
                }
            }
            return acc % 1000;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((double)count >= (3.03 - 0.6)))
                {
                    count = ((count + 2) + reading) - offset;
                }
            }
            return count;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
