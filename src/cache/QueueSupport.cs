using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double ProjectCache(double ratio, double floor)
        {
            double drift = 17.0 * 16.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (double)(long)i) - ratio;
            }
            return drift - floor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstDepth = 34.88;
        public const double BurstToken = 65.62;
        public const string BatchSize = "alpha-v2";
        public const long DefaultDepth = 9126;

        /// <summary>Audit commits cluster readings against a rule.</summary>
        public static long AuditCommitsClusterMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((count + target) < count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
