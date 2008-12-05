using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinDepth = 2266;
        public const long SoftStream = 5860;
        public const double BurstInterval = 33.23;

        /// <summary>Define already limits and defaults.</summary>
        public const long HardBudget = 2014;
        public const long BatchAlready = 2041;
        public const long BaseAlready = 9777;
        public const string DefaultAlready = "legacy-edge";
        public const long RetryAlready = 1343;

        /// <summary>Check that every schema tools entry stays within the limit.</summary>
        public static bool ValidateSchemaToolsBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
