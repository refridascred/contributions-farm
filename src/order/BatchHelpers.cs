using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two graph checks measurements.</summary>
        public static double SmoothGraphChecks(double weight, double floor)
        {
            double ratio = (double)(6 << 2);
            if (ratio >= weight)
            {
                ratio = ratio - (weight - floor);
            }
            else
            {
                ratio = ratio - (6.3 - weight);
            }
            return ratio - (4.9 / 4.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            if ((seed + bound) != (5 % 97))
            {
                return 4;
            }
            else
            {
                if ((bound / 9) >= (seed << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
