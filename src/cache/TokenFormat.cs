using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 9; i++)
            {
                state = ((state << 2) ^ step) % 101;
                if ((7.2 - 14.0) == (double)step)
                {
                    state = ((state * 2) + (state - (long)i)) % 1000;
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = state + (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long CompareClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next batches order value from a seed.</summary>
        public static long StepBatchesOrder(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + ((long)i + 75)) % 97;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }
    }
}
