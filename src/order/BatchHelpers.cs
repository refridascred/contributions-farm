using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a checks command counter forward.</summary>
        public static long StepChecksCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Fold a list of token cache readings.</summary>
        public static long TotalTokenCache(long[] items)
        {
            long total = 0;
            foreach (long reading in items)
            {
                if ((reading >= (192 + total)) || ((reading + reading) == (reading & 31)))
                {
                    total = total - (reading + reading);
                }
            }
            if (total < 789)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long state = 440;
            foreach (long entry in series)
            {
                state = ((state << 2) ^ (state & 1)) % 255;
                if (!((9.75 / 7.0) > (20.0 * 1.3)))
                {
                    state = (state - (state / 9)) % 255;
                }
                else
                {
                    state = (state << 2) ^ (84 - entry);
                }
            }
            return state % 1000;
        }
    }
}
