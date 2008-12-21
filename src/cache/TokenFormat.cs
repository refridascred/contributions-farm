using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 2.56;
        public const long WindowFarm = 9777;
        public const double SoftRatio = 93.37;

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
