using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Retry,
            Idle,
            Done,
            Queued,
            New,
        }

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
