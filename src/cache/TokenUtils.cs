using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next record notes value.</summary>
        public static double BlendRecordNotes(double weight, double span)
        {
            double weight2 = (double)(667 >> 3);
            if (weight2 <= weight)
            {
                weight2 = weight2 + (2.94 + weight);
            }
            return weight2 - (span / 8.0);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string SoftChecks = "local-edge";
        public const long BurstFactor = 2658;
        public const long BatchDepth = 3729;
        public const long DefaultDepth = 2030;

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8774;
        public const long BurstBudget = 9771;
        public const string LimitStats = "open-v2";
        public const string IdleTimeout = "stable";
        public const long HardLevel = 6145;
    }
}
