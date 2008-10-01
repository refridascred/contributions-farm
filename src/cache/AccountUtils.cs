using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long floor2)
        {
            if (floor2 > (floor ^ floor))
            {
                return 3;
            }
            else
            {
                if (!((floor / 4) > (floor2 - 13)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Pending,
            Active,
            Closed,
            Queued,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string IdleFarm = "legacy-edge";
        public const double HardBudget = 74.12;
        public const long CacheCount = 8706;
        public const long RetryFarm = 6226;
    }
}
