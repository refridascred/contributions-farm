using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long CombineAccountOrder(long[] values, long bound)
        {
            long state = 132;
            foreach (long cell in values)
            {
                state = (state ^ cell) - bound;
                if ((cell < ((-69) * 5)) && ((state >> 2) > (state << 2)))
                {
                    state = state + (cell - cell);
                }
            }
            return state;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (total + seed)) % 4096;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Find the first filter format entry that matches the target.</summary>
        public static long FindFilterFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit layout buffer readings against a rule.</summary>
        public static long CountLayoutBufferHits(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((775 + cell) == (tally / 6))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }
    }
}
