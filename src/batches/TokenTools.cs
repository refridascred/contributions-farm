using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of farm order readings.</summary>
        public static long ScoreFarmOrder(long[] levels, long target)
        {
            long sum = -2;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = ((sum * 5) + ((-572) + item)) - (long)i;
                }
                if (((double)item >= (12.0 * 1.2)) || ((target << 2) >= (59 & 3)))
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Dropped,
            Retry,
            Active,
            Stale,
            Ready,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!(acc < (limit % 10)))
                {
                    acc = (acc << 3) ^ (limit >> 2);
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
