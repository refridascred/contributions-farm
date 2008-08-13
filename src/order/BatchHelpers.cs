using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 6162;
        public const long SoftCommits = 3595;
        public const long CacheSize = 3212;
        public const double RetryCommits = 41.93;

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double bias, double bias2)
        {
            double mean = (double)(5 + 8);
            return ((mean - 2.6) + bias) + bias2;
        }
    }
}
