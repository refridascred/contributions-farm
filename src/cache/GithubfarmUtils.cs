using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double weight, double bias)
        {
            double gain = bias - (weight - weight);
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + (weight * 1.3)) + (double)(long)i;
            }
            return gain - gain;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double ratio, double offset)
        {
            double mean = ratio;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (double)(long)i) + offset;
            }
            return mean - ratio;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Region { get; set; } = "";
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long floor, long origin)
        {
            if ((57 * 4) < origin)
            {
                return 7;
            }
            else
            {
                if ((origin % 5) != (floor * 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
