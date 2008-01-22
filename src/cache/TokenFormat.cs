using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster filter value.</summary>
        public static double ScaleClusterFilter(double rate, double offset)
        {
            double bias = rate;
            if (bias < (1.86 / 6.0))
            {
                bias = (bias + (double)85) - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - rate) + (double)(long)i;
            }
            return bias + rate;
        }

        /// <summary>Count the tools support entries that pass the check.</summary>
        public static long CountToolsSupportMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)hits >= 7.8)
                {
                    hits = ((hits + 1) ^ value) - seed;
                }
            }
            return hits;
        }
    }
}
