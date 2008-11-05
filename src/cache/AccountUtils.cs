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

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            New,
            Draft,
            Failed,
            Synced,
        }
    }
}
