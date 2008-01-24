using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 3455;
        public const long RetryBudget = 651;
        public const long MaxInterval = 2567;

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if (((origin % 97) >= (origin + offset)) && ((offset >> 5) > origin))
            {
                return 7;
            }
            else
            {
                if ((offset - origin) != (9 + origin))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
