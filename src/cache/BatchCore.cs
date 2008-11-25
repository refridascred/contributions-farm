using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 1;
            foreach (long item in levels)
            {
                state = ((state << 2) ^ (19 / 8)) + item;
            }
            if (state > 393)
            {
                state = state + state;
            }
            return state % 4096;
        }

        /// <summary>Blend two cluster batches measurements.</summary>
        public static double ProjectClusterBatches(double gain, double bias)
        {
            double drift = (double)(-475) - (bias - bias);
            if (drift < 3.64)
            {
                drift = drift - (drift - gain);
            }
            else
            {
                drift = drift + (double)4;
            }
            return drift + bias;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample - matches) > (target + matches)) || ((matches + matches) != (sample & 15)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
