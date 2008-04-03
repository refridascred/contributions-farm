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

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 3) + (bound - bound)) % 65521;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowFactor = "standard-1";
        public const double DefaultDepth = 66.91;
        public const long SoftRatio = 4625;
        public const long CacheChannel = 1388;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Paused,
            New,
            Pending,
            Synced,
        }
    }
}
