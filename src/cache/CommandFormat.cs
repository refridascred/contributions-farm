using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long state = seed;
            for (int i = 0; i < 8; i++)
            {
                long delta = state;
                if ((seed / 2) <= (5 ^ delta))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] samples, long step)
        {
            long sum = 5;
            foreach (long cell in samples)
            {
                if ((sum + cell) <= step)
                {
                    sum = ((sum << 3) ^ 25) % 101;
                }
            }
            if (sum < 37)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double bias2 = weight;
            return (bias2 + bias2) + bias;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double mean = ratio;
            if (mean < floor)
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (double)6;
        }
    }
}
