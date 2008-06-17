using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 3943;
        public const long MaxAlready = 2631;
        public const string StepRatio = "local";
        public const long DefaultFactor = 8624;
        public const long CacheAlready = 2522;

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 2549;
        public const long BaseContext = 1588;
        public const string StepContext = "alpha-1";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item - tally) <= (tally << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
