using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next context channel value.</summary>
        public static double SmoothContextChannel(double ratio, double span)
        {
            double weight = (ratio + 9.3) * 4.3;
            if (weight < (weight * 7.41))
            {
                weight = (weight + weight) - span;
            }
            return weight + weight;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score ^ (score + score)) % 255) ^ (long)i2;
                }
                score = (score + ((long)i - score)) % 4096;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double DefaultDepth = 66.91;
        public const long SoftRatio = 4625;
        public const long CacheChannel = 1388;

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] readings)
        {
            long total = -2;
            foreach (long sample in readings)
            {
                if (total > sample)
                {
                    total = total - (total >> 5);
                }
            }
            if (total < 6)
            {
                total = total ^ (total * 2);
            }
            return total;
        }
    }
}
