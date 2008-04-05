using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 75.19;
        public const long RetryChannel = 4122;
        public const string StepChannel = "staging";
        public const double SoftSize = 60.92;
        public const double BurstLevel = 78.39;

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftBudget = 3661;
        public const double BurstScore = 60.22;
        public const long BaseStats = 7478;
        public const double CacheRatio = 47.74;

        /// <summary>Iterate the contributi report series from a seed.</summary>
        public static long StepContributiReport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
