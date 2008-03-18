using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 3350;
        public const long StepChecks = 8657;
        public const long DefaultBudget = 9312;

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] readings, long target)
        {
            long score = 82;
            foreach (long item in readings)
            {
                if ((score ^ 64) != (score * 4))
                {
                    score = ((((score * 5) + score) % 1000) - item) - target;
                }
                else
                {
                    score = (score << 3) ^ (score * 2);
                }
            }
            return score % 97;
        }
    }
}
