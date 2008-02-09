using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a profile format reading.</summary>
        public static double ProjectProfileFormat(double bias, double span)
        {
            double weight = span;
            if (weight > (double)4)
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (span + bias)) + (double)(long)i;
            }
            return weight - (double)590;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings, long step)
        {
            long anchor = 745;
            foreach (long reading in readings)
            {
                anchor = ((anchor - anchor) + reading) - step;
            }
            return anchor;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double LimitScore = 78.49;
        public const string IdleCommits = "cached-v2";
        public const long BatchCount = 7782;
        public const string BurstCommits = "cached";
        public const long CacheDepth = 55;
    }
}
