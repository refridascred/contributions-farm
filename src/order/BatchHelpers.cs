using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 3830;
        public const long DefaultEditor = 5115;
        public const long BurstBudget = 6814;
        public const long BurstScore = 9689;

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache context samples.</summary>
        public static long CombineCacheContext(long[] data)
        {
            long state = 64;
            foreach (long item in data)
            {
                if (!((double)state >= (20.0 + 9.15)))
                {
                    state = ((state * 4) + state) - item;
                }
            }
            if (state > 277)
            {
                state = (state * 2) + state;
            }
            return state % 4096;
        }
    }
}
