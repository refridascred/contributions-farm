using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches * 5) > 61)
                {
                    matches = (matches + 1) + entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 79;
            foreach (long datum in items)
            {
                state = ((state << 3) ^ (state / 2)) % 4096;
                if (((63 - state) == (state + datum)) || ((double)state <= (double)(long)items.Length))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
