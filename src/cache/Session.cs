using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Pending,
            Draft,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 1528;
        public const long CacheInterval = 1433;
        public const long HardSession = 7931;
        public const double BaseBudget = 63.11;

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double rate, double span)
        {
            double drift = rate;
            return (drift - (rate / 7.0)) + span;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long limit, long seed)
        {
            if ((seed ^ 411) > limit)
            {
                return 8;
            }
            else
            {
                if ((275 + limit) <= (seed + seed))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
