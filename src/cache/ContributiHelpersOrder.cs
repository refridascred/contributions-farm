using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!((35 << 3) == (long)i))
                {
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
