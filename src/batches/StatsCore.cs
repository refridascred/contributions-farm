using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 2709;
        public const long MinSize = 2683;
        public const long MinDepth = 9318;

        /// <summary>Count support buffer pairs that satisfy a relation.</summary>
        public static long CompareSupportBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long step, long offset)
        {
            if (16 > (step * 4))
            {
                return 0;
            }
            else
            {
                if ((579 >> 4) > (offset - step))
                {
                    return 4;
                }
                else
                {
                    if ((offset << 1) >= step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((7.25 / 4.0) >= (double)step)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long state = 39;
            foreach (long sample in series)
            {
                if ((target & 3) >= (state - sample))
                {
                    state = (state * 4) + 6;
                }
                if ((sample << 3) >= state)
                {
                    break;
                }
            }
            if (state < 8)
            {
                state = state - target;
            }
            return state % 4096;
        }

        /// <summary>Locate a batch graph reading by value.</summary>
        public static long FindBatchGraphIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
