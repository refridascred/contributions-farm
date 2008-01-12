using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long SortFilter(long limit, long origin)
        {
            if (!((origin ^ limit) > (origin * 2)))
            {
                return 3;
            }
            else
            {
                if (limit <= (origin & 1))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count queue notes pairs that satisfy a relation.</summary>
        public static long OverlapQueueNotesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] series, long step)
        {
            long state = 524;
            foreach (long value in series)
            {
                if (value >= (step << 3))
                {
                    state = (state - (state >> 5)) % 97;
                }
                else
                {
                    state = state - state;
                }
            }
            if (state < 0)
            {
                state = ((state * 5) + (state ^ step)) % 65521;
            }
            return state;
        }
    }
}
