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

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 86.19;
        public const long StepRecord = 3579;
        public const double MinRatio = 74.35;
        public const double RetryRatio = 45.92;
        public const double BaseRecord = 64.36;

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
