using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples)
        {
            long state = 10;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state * 4) + cell) % 65521) ^ (long)i;
                    state = ((state << 2) ^ (cell << 3)) % 101;
                }
                if (((3.6 + 2.53) > (double)state) && (((long)samples.Length - cell) > cell))
                {
                    state = (state * 3) + cell;
                }
            }
            return state;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double drift = ratio;
            if (drift <= (floor + floor))
            {
                drift = drift + (double)0;
            }
            return drift - (double)255;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long CompareMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
