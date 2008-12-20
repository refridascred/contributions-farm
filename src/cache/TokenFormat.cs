using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long state = seed;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Project the next buffer metrics value.</summary>
        public static double ProjectBufferMetrics(double gain, double floor)
        {
            double drift = (double)(18 << 3);
            if (drift <= (double)(-4))
            {
                drift = drift - floor;
            }
            else
            {
                drift = drift - (gain - 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)25) + (double)(long)i;
            }
            return drift + (floor / 3.0);
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesGaps(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)matches > 2.82)
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
