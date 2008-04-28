using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] items, long bound)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two layout counter measurements.</summary>
        public static double SmoothLayoutCounter(double gain, double floor)
        {
            double scale = (double)(484 % 5);
            if (scale < (floor / 8.0))
            {
                scale = scale - (4.6 * 6.99);
            }
            return scale + (gain - floor);
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Weight { get; set; } = "";
            public string Region { get; set; } = "";
        }
    }
}
