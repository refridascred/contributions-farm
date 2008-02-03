using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double weight, double span)
        {
            double load = 4.6;
            if (load < weight)
            {
                load = load - (span / 7.0);
            }
            return load + (6.42 * 4.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 2208;
        public const double HardLevel = 58.98;
        public const long BurstBudget = 1954;
        public const double WindowRoute = 59.38;

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "primary-1";
        public const long LimitPayload = 5263;
        public const long HardRatio = 1424;
        public const long IdlePayload = 8083;
        public const long LimitSize = 2586;
    }
}
