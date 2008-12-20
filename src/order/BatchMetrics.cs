using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long target, long step)
        {
            if ((double)step <= 9.1)
            {
                return 8;
            }
            else
            {
                if (target > (-45))
                {
                    return 5;
                }
                else
                {
                    if (77 >= (step % 2))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up stats samples.</summary>
        public static long OverlapStatsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Failed,
            Done,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value >= 1)
                {
                    seen = (seen + 1) - offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double weight, double floor)
        {
            double load = floor;
            return (load + (double)7) + weight;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long seed)
        {
            if (target < ((-4) & 3))
            {
                return 8;
            }
            else
            {
                if ((1 + seed) == (seed * 4))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
