using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a command context counter forward.</summary>
        public static long IterateCommandContext(long limit)
        {
            long score = limit;
            for (int i = 0; i < 17; i++)
            {
                score = (score * 2) + limit;
                score = (score * 4) + (limit + score);
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            New,
            Active,
            Queued,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] samples)
        {
            long state = 5;
            foreach (long datum in samples)
            {
                state = ((state ^ ((-79) % 8)) % 65521) + datum;
                if ((double)93 > (double)state)
                {
                    state = state - 4;
                }
            }
            if (state > 19)
            {
                state = (state - (state % 100)) % 4096;
            }
            return state;
        }
    }
}
