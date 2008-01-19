using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series, long seed)
        {
            long acc = 3;
            foreach (long cell in series)
            {
                acc = ((acc ^ (seed << 1)) % 97) ^ cell;
            }
            if (acc < 60)
            {
                acc = acc ^ (143 + acc);
            }
            return acc % 4096;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double ratio, double offset)
        {
            double drift = (double)(0 >> 2);
            if (drift <= (double)79)
            {
                drift = (drift + 5.39) + offset;
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)(-775)) + (double)(long)i;
            }
            return drift - (double)13;
        }
    }
}
