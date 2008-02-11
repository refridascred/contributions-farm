using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            Paused,
            Synced,
            Draft,
            Pending,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long floor)
        {
            if (0 > (floor / 3))
            {
                return 3;
            }
            else
            {
                if (!((double)limit <= 10.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)limit < 13.0) && ((limit - limit) > (limit << 3)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowGraph = 9138;
        public const double BaseGraph = 4.81;
        public const long IdleRatio = 6190;
        public const long DefaultSpan = 4285;
    }
}
