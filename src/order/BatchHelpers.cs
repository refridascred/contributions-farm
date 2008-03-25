using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] data, long floor)
        {
            long score = 283;
            foreach (long item in data)
            {
                if ((score << 3) > (score * 2))
                {
                    score = ((score ^ (score - item)) % 97) - floor;
                }
            }
            return score;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double bias)
        {
            double load = bias / 2.0;
            if (load >= (bias * 16.0))
            {
                load = (load - (double)3) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)tally < (double)295)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
