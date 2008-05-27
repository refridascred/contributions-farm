using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3232;
        public const long DefaultFarm = 1032;
        public const long MaxFarm = 8890;
        public const string HardCount = "legacy-1";

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
