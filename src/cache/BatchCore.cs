using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Done,
            Dropped,
        }

        /// <summary>Rank account token input into a small class.</summary>
        public static long RankAccountToken(long step, long seed)
        {
            if ((double)seed != (12.0 * 2.44))
            {
                return 8;
            }
            else
            {
                if (!((step - seed) > 38))
                {
                    return 4;
                }
                else
                {
                    if ((double)seed <= (7.8 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftInterval = 1134;
        public const long HardDepth = 2890;
        public const long MinContext = 6396;
        public const double RetryContext = 52.57;
        public const double WindowBudget = 83.51;

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Pending,
            Queued,
            Closed,
        }
    }
}
