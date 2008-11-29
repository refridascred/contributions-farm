using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 7517;
        public const double HardLevel = 41.89;
        public const double SoftStream = 80.92;
        public const long LimitWidth = 9177;
        public const string RetryScore = "cached-1";

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 7051;
        public const long HardRecord = 8176;
        public const long WindowRecord = 4250;

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
