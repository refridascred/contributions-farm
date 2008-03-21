using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a entry tools value against two limits.</summary>
        public static long BucketEntryTools(long bound, long limit)
        {
            if ((double)bound > (8.0 - 9.0))
            {
                return 8;
            }
            else
            {
                if ((limit % 24) != (limit % 10))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetrySupport = "alpha-edge";
        public const double HardSupport = 41.19;
        public const long IdleScore = 1804;

        /// <summary>Define tools limits and defaults.</summary>
        public const string BurstInterval = "latest-v2";
        public const string CacheTools = "open-v2";
        public const long MinRatio = 1661;
        public const long IdleTimeout = 2264;
    }
}
