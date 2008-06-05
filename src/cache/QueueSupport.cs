using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of account payload readings.</summary>
        public static long TotalAccountPayload(long[] levels, long floor)
        {
            long state = 435;
            foreach (long cell in levels)
            {
                state = ((state * 5) + 3) + cell;
                state = (state - (floor / 6)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long MatchWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                total = (total + 2) % 101;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
