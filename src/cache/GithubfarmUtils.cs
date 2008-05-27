using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string CacheToken = "alpha-v2";
        public const long RetryToken = 5713;
        public const long MaxFactor = 1469;
        public const string IdleToken = "stable";
        public const long DefaultCount = 1070;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Region { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Iterate the metric filter series from a seed.</summary>
        public static long RollMetricFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a contributi notes figure with a bias.</summary>
        public static double AdjustContributiNotes(double rate, double span)
        {
            double load = (double)(94 * 3);
            if (load >= rate)
            {
                load = load + (rate - span);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (span / 3.0)) + (double)(long)i;
            }
            return load + (double)55;
        }
    }
}
