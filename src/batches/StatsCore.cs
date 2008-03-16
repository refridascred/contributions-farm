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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits >> 4) < 906) || ((hits + 43) > (cell + cell)))
                {
                    hits = hits + 3;
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

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] series, long offset)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((47 * 2) >= entry)
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
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
