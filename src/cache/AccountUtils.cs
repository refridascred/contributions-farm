using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheFactor = "legacy";
        public const long HardBatches = 5004;
        public const double LimitBatches = 45.23;
        public const string HardLevel = "cached";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 6779;
        public const double CacheCluster = 0.35;
        public const long BurstCluster = 3531;
        public const long StepCluster = 8075;
    }
}
