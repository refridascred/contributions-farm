using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstScore = 4522;
        public const long HardInterval = 3964;
        public const double SoftFarm = 54.46;
        public const long WindowFarm = 3155;

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 5629;
        public const double RetryBudget = 93.69;
        public const string HardChecks = "staging-v2";

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
