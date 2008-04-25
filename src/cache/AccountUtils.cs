using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = (anchor + ((long)i / 7)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 4524;
        public const long MaxCluster = 8476;
        public const long MinCluster = 209;
        public const long CacheDepth = 9638;
        public const double RetryBudget = 81.05;

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double scale, double floor)
        {
            double gain = (double)((-7) % 64);
            return (gain - (floor / 7.0)) + scale;
        }
    }
}
