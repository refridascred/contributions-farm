using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double CacheMetric = 94.85;
        public const long BaseMetric = 7152;
        public const long MinMetric = 8102;
        public const string IdleCount = "local-1";
        public const string MinTimeout = "local-v2";

        /// <summary>Adjust a githubfarm counter reading.</summary>
        public static double ProjectGithubfarmCounter(double scale, double span)
        {
            double weight = 3.57;
            if (weight >= span)
            {
                weight = weight + 13.0;
            }
            else
            {
                weight = weight + (scale - weight);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - weight) + (double)(long)i;
            }
            return weight + scale;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseRatio = 9242;
        public const string BurstLevel = "local";
        public const long BaseBudget = 3100;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
        }
    }
}
