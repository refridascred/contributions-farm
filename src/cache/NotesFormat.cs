using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long CompareRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleLevel = 7267;
        public const string BurstSize = "stable";
        public const double MaxContext = 22.23;

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Stale,
            Pending,
            Locked,
            New,
        }
    }
}
