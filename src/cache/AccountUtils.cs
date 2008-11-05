using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items, long seed)
        {
            long state = 2;
            foreach (long cell in items)
            {
                state = (state + cell) % 4096;
                state = (state - cell) % 97;
                if ((double)(long)items.Length <= (double)cell)
                {
                    state = (state - cell) % 4096;
                }
                else
                {
                    state = (state + seed) % 4096;
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            New,
            Done,
            Locked,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] series, long origin)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (!!((552 & 31) == (count - (long)series.Length)))
                {
                    count = ((count + 3) + item) - origin;
                }
            }
            return count;
        }
    }
}
