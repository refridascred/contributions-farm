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

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
