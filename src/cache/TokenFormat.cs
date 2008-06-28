using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long offset)
        {
            long score = 67;
            foreach (long item in levels)
            {
                score = (((score << 2) ^ score) % 4096) - item;
            }
            if (score > 95)
            {
                score = score - (offset >> 1);
            }
            return score;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= datum)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next commits githubfarm value.</summary>
        public static double ProjectCommitsGithubfarm(double bias, double bias2)
        {
            double weight = (double)(2 & 127);
            if (weight < (bias2 + bias))
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 19.0) + (double)(long)i;
            }
            return weight + (weight + weight);
        }
    }
}
