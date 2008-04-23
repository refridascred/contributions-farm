using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardLevel = 8651;
        public const string MaxDepth = "standard-v2";
        public const long DefaultTimeout = 1695;
        public const string HardBatch = "fallback-1";

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long bound)
        {
            if (!((58 * 4) == (bound ^ 843)))
            {
                return 8;
            }
            else
            {
                if (6.8 < (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count != (3.0 / 8.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
