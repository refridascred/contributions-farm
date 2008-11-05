using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
