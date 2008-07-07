using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 2384;
        public const string CacheDepth = "legacy-1";
        public const double RetryStream = 83.53;

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinWidth = 3555;
        public const double SoftRatio = 53.21;
        public const double DefaultFactor = 97.39;

        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (double)88;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (ratio + ratio)) - (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
