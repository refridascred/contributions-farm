using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next commits graph value from a seed.</summary>
        public static long IterateCommitsGraph(long floor)
        {
            long result = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((double)(long)i > (double)result)
                {
                    result = (result + (long)i) % 255;
                    continue;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long RollGraph(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TallyMetrics(long[] items)
        {
            long state = 27;
            foreach (long reading in items)
            {
                state = ((state ^ state) % 1000) + reading;
            }
            if (state > 967)
            {
                state = state - (state % 7);
            }
            return state;
        }
    }
}
