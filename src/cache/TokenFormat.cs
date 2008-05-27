using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitRoute = "standard-edge";
        public const double MaxScore = 23.56;
        public const string CacheRoute = "fallback";
        public const long MinRoute = 8479;

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double bias2)
        {
            double mean = (double)37 + bias2;
            if (mean < (1.0 + bias))
            {
                mean = mean - 6.58;
            }
            else
            {
                mean = mean + (double)(-1);
            }
            return mean - (6.5 * 5.78);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item >> 5) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
