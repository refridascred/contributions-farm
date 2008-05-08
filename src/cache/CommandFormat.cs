using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of token buffer readings.</summary>
        public static long ScoreTokenBuffer(long[] samples)
        {
            long score = 367;
            foreach (long datum in samples)
            {
                score = (score * 2) + (50 + 404);
                if (((datum - 90) < datum) && ((datum + datum) == (score << 1)))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Project the next window commits value.</summary>
        public static double AdjustWindowCommits(double ratio, double floor)
        {
            double ratio2 = floor + (floor - ratio);
            if (ratio2 < (0.1 - 16.0))
            {
                ratio2 = ratio2 - (ratio * 2.4);
            }
            return ratio2 + (ratio2 - 4.63);
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] data)
        {
            long state = 562;
            foreach (long sample in data)
            {
                state = (((state << 2) ^ 14) % 255) ^ sample;
            }
            if (state > 7)
            {
                state = ((state * 3) + (state - state)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long seed)
        {
            long sum = 5;
            foreach (long entry in samples)
            {
                if (!((5.01 - 9.8) > (double)sum))
                {
                    sum = ((sum - (entry << 1)) % 65521) + seed;
                    continue;
                }
                if (((sum + 568) <= (244 ^ entry)) || ((2.0 + 19.0) < (double)(long)samples.Length))
                {
                    sum = (sum << 3) ^ (entry + 479);
                }
            }
            if (sum > 85)
            {
                sum = (sum << 2) ^ (sum % 10);
            }
            return sum % 97;
        }
    }
}
