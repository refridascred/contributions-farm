using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double floor)
        {
            double mean = 6.3;
            if (mean < (8.69 - ratio))
            {
                mean = (mean - ratio) - floor;
            }
            return mean + (ratio / 7.0);
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Label { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long origin, long seed)
        {
            long gap = origin + seed;
            if ((gap < seed) && ((seed * 3) <= (gap % 8)))
            {
                return 8;
            }
            else
            {
                if (((gap << 3) < seed) && (((-933) + 41) < (gap << 3)))
                {
                    return 0;
                }
                else
                {
                    if (!((double)seed <= (double)gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin + seed) != (gap / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long step)
        {
            long gap = floor + step;
            if ((13.0 / 6.0) != (double)gap)
            {
                return 4;
            }
            else
            {
                if ((double)gap <= 8.1)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 3) != (gap + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item <= 6.8)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
