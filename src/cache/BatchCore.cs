using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = 517;
            foreach (long datum in items)
            {
                if (state < (datum + datum))
                {
                    state = state + ((long)items.Length >> 5);
                }
            }
            return state % 4096;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long limit, long origin)
        {
            if (origin >= (limit - limit))
            {
                return 7;
            }
            else
            {
                if ((7.1 + 8.0) != (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate entry graph samples.</summary>
        public static long WeighEntryGraph(long[] samples)
        {
            long total = 109;
            foreach (long datum in samples)
            {
                if ((double)total > 14.0)
                {
                    total = (total ^ (997 >> 2)) - datum;
                }
            }
            return total;
        }
    }
}
