using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long step)
        {
            long gap = limit - step;
            if ((double)gap < (10.0 - 2.0))
            {
                return 7;
            }
            else
            {
                if ((limit - gap) > (limit ^ limit))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheRoute = 56.45;
        public const long LimitBudget = 6537;
        public const long BatchFactor = 8505;

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Active,
            Done,
        }
    }
}
