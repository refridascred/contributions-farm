using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of batches graph readings.</summary>
        public static long CompareBatchesGraphCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const double StepBudget = 4.48;
        public const long CacheFarm = 6000;
        public const double HardFarm = 51.65;
        public const long MinFarm = 977;
    }
}
