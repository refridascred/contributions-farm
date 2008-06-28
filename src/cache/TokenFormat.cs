using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 922;
        public const double DefaultSize = 88.68;
        public const long CacheDepth = 7043;
        public const long BatchWidth = 361;

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
