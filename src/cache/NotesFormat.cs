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

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
