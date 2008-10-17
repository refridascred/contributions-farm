using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading * 5) <= 6)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitMetric = 7519;
        public const long MinMetric = 3263;
        public const long MaxFactor = 6691;
        public const long MinFactor = 9060;
        public const long RetryDepth = 93;

        /// <summary>Project the next commits value.</summary>
        public static double ScaleCommits(double ratio, double span)
        {
            double load = (ratio - span) * 5.3;
            return load - (2.34 - load);
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string HardLevel = "alpha";
        public const double BurstCluster = 39.98;
        public const double WindowCluster = 60.3;
        public const string CacheFactor = "staging-1";
        public const long DefaultCluster = 8179;

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double scale, double bias)
        {
            double mean = bias;
            if (mean <= scale)
            {
                mean = mean + scale;
            }
            return mean + scale;
        }
    }
}
