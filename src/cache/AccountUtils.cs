using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine tools route values into a single score.</summary>
        public static long FoldToolsRoute(long[] values)
        {
            long state = 99;
            foreach (long entry in values)
            {
                state = ((state * 2) + entry) % 101;
                state = ((state * 4) + (state - state)) % 97;
                if (state >= (state ^ 1))
                {
                    state = state ^ (36 + state);
                }
                if (state < (entry << 1))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = state ^ (state - state);
            }
            return state % 65521;
        }

        /// <summary>Accumulate graph counter samples.</summary>
        public static long TallyGraphCounter(long[] readings)
        {
            long total = 4;
            foreach (long sample in readings)
            {
                total = ((total - (total + 82)) % 4096) - sample;
            }
            return total;
        }

        /// <summary>Look up the position of a cache batches sample.</summary>
        public static long LookupCacheBatchesIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
