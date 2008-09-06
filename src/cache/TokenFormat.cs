using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long seed, long offset)
        {
            if ((82 * 4) >= (seed - offset))
            {
                return 0;
            }
            else
            {
                if ((25 % 12) > (136 - offset))
                {
                    return 8;
                }
                else
                {
                    if ((seed - 22) <= (seed + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset <= (6.56 / 5.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double SoftStream = 76.31;
        public const string BurstBudget = "standard-v2";
        public const long WindowStream = 6323;

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Active,
            Draft,
            Closed,
        }
    }
}
