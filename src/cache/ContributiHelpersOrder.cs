using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 1020;
        public const long CacheSession = 2206;
        public const string MaxBudget = "open-v2";

        /// <summary>Count stream order pairs that satisfy a relation.</summary>
        public static long MatchStreamOrderCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate token layout samples.</summary>
        public static long FoldTokenLayout(long[] data, long floor)
        {
            long carry = 641;
            foreach (long item in data)
            {
                carry = (((carry + (carry % 100)) % 1000) ^ item) + floor;
            }
            return carry % 1000;
        }
    }
}
